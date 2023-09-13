using ParserKupiProday.Core.Core;
using System;
using AngleSharp.Html.Parser;
using AngleSharp.Html.Dom;
using System.IO;
using OfficeOpenXml;
using System.Collections.Generic;

namespace ParserKupiProday.Core
{
    internal class LinksParserWorker<T> where T : class
    {
        private IParser<string[]> linkParser;
        private IParserSettings parserSettings;
        private IHtmlDocument document;
        private HtmlLinksLoader linksLoader;
        private bool isActive;

        public event Action<object, string[]> OnNewLinkData;
        public event Action<object> OnCompleted;

        public IParser<string[]> LinkParser
        {
            get { return linkParser; }
            set { linkParser = value; }
        }

        public IParserSettings Settings
        {
            get { return parserSettings; }
            set
            {
                parserSettings = value;
                linksLoader = new HtmlLinksLoader(value);
            }
        }

        public bool IsActive => isActive;

        public LinksParserWorker(IParser<string[]> linkParser)
        {
            this.linkParser = linkParser;
        }

        public LinksParserWorker(IParser<string[]> linkParser, IParserSettings parserSettings) : this(linkParser)
        {
            this.parserSettings = parserSettings;
        }

        public void LinkStart(string filePath, string dataSavePath, int startPoint, int endPoint, string oblast)
        {
            string[] links = GetLinks(filePath);
            isActive = true;
            LinkWorker(links, dataSavePath, startPoint, endPoint, oblast);
        }

        public void Stop()
        {
            isActive = false;
        }

        private async void LinkWorker(string[] links, string dataSavePath, int startPoint, int endPoint, string oblast)
        {
            if(endPoint == 0) { endPoint = links.Length; }

            for (int i = startPoint-1; i < endPoint; i++)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                var source = await linksLoader.GetSourceByLinkId(links[i].ToString());
                var domParser = new HtmlParser();

                document = await domParser.ParseDocumentAsync(source);

                var parsedData = linkParser.LinkParser(document, dataSavePath, oblast);

                OnNewLinkData?.Invoke(this, parsedData);
                //await Task.Delay(15000);
            }

            OnCompleted?.Invoke(this);
            isActive = false;
        }
        private string[] GetLinks(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            ExcelPackage package = new ExcelPackage(file);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            List<string> dataArray = new List<string>();

            // Перебираем все листы в файле
            foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets)
            {
                // Определяем количество строк в текущем листе
                int rowCount = worksheet.Dimension.Rows;

                // Считываем данные из листа и добавляем их в список
                for (int row = 1; row <= rowCount; row++)
                {
                    dataArray.Add(worksheet.Cells[row, 1].Value?.ToString());
                }
            }

            package.Dispose();

            return dataArray.ToArray();
        }

    }
}
