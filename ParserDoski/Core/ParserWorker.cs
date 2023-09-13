using ParserKupiProday.Core.Core;
using System;
using AngleSharp.Html.Parser;

namespace ParserKupiProday.Core
{
    internal class ParserWorker<T> where T : class
    {
        private IParser<string[]> parser;
        private IParserSettings parserSettings;
        private HtmlLoader loader;
        private bool isActive;

        public event Action<object, string[]> OnNewData;
        public event Action<object> OnCompleted;

        public IParser<string[]> Parser
        {
            get { return parser; }
            set { parser = value; }
        }

        public IParserSettings Settings
        {
            get { return parserSettings; }
            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }

        public bool IsActive => isActive;

        public ParserWorker(IParser<string[]> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<string[]> parser, IParser<string[]> linkParser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }


        public void Start(string linksPPathSave)
        {
            isActive = true;
            Worker(linksPPathSave);
        }

        public void Stop()
        {
            isActive = false;
        }

        private async void Worker(string linksPathSave)
        {
            for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }
                var code = await loader.GetStatusCodeByPageId(i);
                if (code == "302") { break; }

                var source = await loader.GetSourceByPageId(i);
                var domParser = new HtmlParser();

                var document = await domParser.ParseDocumentAsync(source);

                var parsedData = parser.Parse(document, linksPathSave);

                OnNewData?.Invoke(this, parsedData);
            }

            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
