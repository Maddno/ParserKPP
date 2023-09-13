using AngleSharp.Html.Dom;
using System.Collections.Generic;
using ParserKupiProday.Core.Core;
using System.Net.Http;
using System.IO;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.IO.Compression;

namespace ParserKupiProday.Core.KupiProday
{
    internal class KPParser : IParser<string[]>
    {

        private readonly HttpClient httpClient;
        
        public KPParser()
        {
            httpClient = new HttpClient();
            
        }

        public string[] Parse(IHtmlDocument document, string linksPathSave)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll(".list_title");

            foreach (var item in items)
            {
                list.Add(item.GetAttribute("href"));
            }

            string[] linkResult = list.ToArray();

            //LinkList(linkResult);
            SaveToExcel(linkResult, linksPathSave);

            return linkResult;
        }

        public string[] LinkParser(IHtmlDocument document, string dataPathSave, string oblast)
        {
            var list = new List<string>();

            var region = document.QuerySelector("div.msg_info.width100.margin_bottom_20.box-sizing p:nth-child(3)")?.TextContent?.Trim();
            list.Add(region);

            var titles = document.QuerySelector("h1.msg_h1")?.TextContent?.Trim();
            list.Add(titles);

            var price = document.QuerySelector("div.msg_price.bold")?.TextContent?.Trim();
            list.Add(price);

            var name = document.QuerySelector("a.grey_text_3")?.TextContent?.Trim();
            list.Add(name);

            var number = GetNumber(document, oblast);
            list.Add(number);

            string result = string.Join("^", list);

            SaveToExcel(new string[] { result }, dataPathSave);

            return new string[] { result };
        }

        public void SaveToExcel(string[] data, string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            bool fileExists = file.Exists;

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet;

                // Если файл существует, получаем первый лист
                if (fileExists)
                {
                    worksheet = package.Workbook.Worksheets[0];
                }
                else // Если файл не существует, создаем новый лист
                {
                    worksheet = package.Workbook.Worksheets.Add("Sheet1");
                }

                // Определяем, на какой строке начинается добавление новых данных
                int startRow = fileExists && worksheet.Dimension != null ? worksheet.Dimension.Rows + 1 : 1;


                // Добавляем новые данные в ячейки
                for (int i = 0; i < data.Length; i++)
                {
                    worksheet.Cells[startRow + i, 1].Value = data[i];
                }

                // Сохраняем изменения в файле
                package.Save();

                // Закрываем пакет Excel
                package.Dispose();
            }
        }

        public string GetNumber(IHtmlDocument document, string oblast)
        {
            using (var httpClientHandler = new HttpClientHandler())
            {
                var id = document.QuerySelector("a.favorite_add")?.GetAttribute("data-bbs_id");

                // Используем HtmlAgilityPack для извлечения значения bbs_phone_hash
                var scriptElement = document.QuerySelectorAll("script")
                    .FirstOrDefault(script => script.TextContent.Contains("bbs_phone_hash"));

                string bbsPhoneHash = null;
                if (scriptElement != null)
                {
                    // Использование регулярного выражения для извлечения значения bbs_phone_hash
                    string scriptContent = scriptElement.TextContent;
                    string pattern = @"bbs_phone_hash\s*=\s*""(\w+)""";
                    var match = System.Text.RegularExpressions.Regex.Match(scriptContent, pattern);

                    if (match.Success)
                    {
                        bbsPhoneHash = match.Groups[1].Value;

                        var cookieContainer = new CookieContainer();

                        // Добавление куки в CookieContainer
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("__ddg1_", "Xgg7N724vLDBTvwcz9kf"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("_ga", "GA1.2.1809975747.1685360124"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("_gat", "1"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("_gid", "GA1.2.1845390033.1687786818\t"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("email" ,"lorico7295%40goflipa.com"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("favorite", "45ac1d502fc56c3c80c2c18fdbd85c14"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("lastdata", "2023-05-29+14%3A48%3A47"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("lastpage", "%2Fsignin%2Fcomplete%2F"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("lastpagedomain", "kupiprodai.ru%2Flogin%2F"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("lastref", "%2Fkupiprodai.ru%2F"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("lastrefdomain", "%2Fkupiprodai.ru%2F"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("lt", "c3c0cddd5f9e947f956c43dc4dc09ec4"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("mobile", "1"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("PHPSESSID", "a6r0n2ill9imlfvnaboe91ebd3"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("region_change", "6"));
                        cookieContainer.Add(new Uri("https://kupiprodai.ru"), new Cookie("thello", "134eeae2f5e574dd656846f200f037c6"));

                        using (var httpClient = new HttpClient(httpClientHandler))
                        {

                            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            httpClient.DefaultRequestHeaders.Add("Accept", "application/json, text/javascript, */*; q=0.01");
                            httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
                            httpClient.DefaultRequestHeaders.Add("Accept-Language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7,uk;q=0.6");
                            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36");
                            httpClient.DefaultRequestHeaders.Add("Dnt", "1");
                            httpClient.DefaultRequestHeaders.Add("Referer", $"{oblast}kupiprodai.ru/");
                            httpClient.DefaultRequestHeaders.Add("Origin", $"{oblast}kupiprodai.ru");
                            httpClient.DefaultRequestHeaders.Add("Sec-Ch-Ua", "\"Not.A/Brand\";v=\"8\", \"Chromium\";v=\"114\", \"Google Chrome\";v=\"114\"");
                            httpClient.DefaultRequestHeaders.Add("Sec-Ch-Ua-Mobile", "?0");
                            httpClient.DefaultRequestHeaders.Add("Sec-Ch-Ua-Platform", "\"Windows\"");
                            httpClient.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
                            httpClient.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
                            httpClient.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-site");
                            httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
                            httpClient.DefaultRequestHeaders.Add("Host", "kupiprodai.ru");


                            var requestUrl = $"https://kupiprodai.ru/phone.php?id={Uri.EscapeDataString(id)}&hash={Uri.EscapeDataString(bbsPhoneHash)}";
                            httpClientHandler.CookieContainer = cookieContainer;

                            var response = httpClient.GetAsync(requestUrl).Result;
                            var responseContent = response.Content.ReadAsStringAsync().Result;

                            // Проверка заголовка Content-Encoding на наличие gzip
                            if (response.Content.Headers.ContentEncoding.Contains("gzip"))
                            {
                                using (var stream = response.Content.ReadAsStreamAsync().GetAwaiter().GetResult())
                                using (var gzipStream = new GZipStream(stream, CompressionMode.Decompress))
                                using (var reader = new StreamReader(gzipStream))
                                {
                                    var decodedContent = reader.ReadToEnd();
                                    return decodedContent;
                                }
                            }
                            else
                            {
                                // Если ответ не сжат gzip, читаем его как обычно
                                return responseContent;
                            }
                        }
                    }
                }

                return null;
            }
        }


        /*public async Task<string> SendPostRequestWithHeaders(IHtmlDocument document)
        {
            using (var httpClient = new HttpClient())
            {
                var id = document.QuerySelector("a.favorite_add")?.GetAttribute("data-bbs_id");

                // Используем HtmlAgilityPack для извлечения значения bbs_phone_hash
                var scriptElement = document.QuerySelectorAll("script")
                    .FirstOrDefault(script => script.TextContent.Contains("bbs_phone_hash"));

                string bbsPhoneHash = null;
                if (scriptElement != null)
                {
                    // Использование регулярного выражения для извлечения значения bbs_phone_hash
                    string scriptContent = scriptElement.TextContent;
                    string pattern = @"bbs_phone_hash\s*=\s*""(\w+)""";
                    var match = System.Text.RegularExpressions.Regex.Match(scriptContent, pattern);

                    if (match.Success)
                    {
                        bbsPhoneHash = match.Groups[1].Value;

                        var postData = new Dictionary<string, string>
                        {
                            { "id", id },
                            { "hash", bbsPhoneHash }
                        };

                        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        httpClient.DefaultRequestHeaders.Add("CustomHeader", "Значение заголовка");

                        var response = httpClient.PostAsync($"https://kupiprodai.ru/phone.php?id={id}&hash={bbsPhoneHash}", new FormUrlEncodedContent(postData)).Result;
                        var responseContent = response.Content.ReadAsStringAsync().Result;

                        return responseContent;
                    }
                }

                return null;
            }
        }*/



    }
}
