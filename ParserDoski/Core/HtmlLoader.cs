using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using AngleSharp.Html.Parser;
using AngleSharp.Html.Dom;
using System.Linq;

namespace ParserKupiProday.Core
{
    internal class HtmlLoader
    {
        private readonly HttpClient client;
        private readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.Sufix}{settings.BaseUrl}{settings.Prefix}{settings.SubPrefix}/page{{CurrentId}}/?personal=0";
            //seleniumCapcha = new SeleniumCapcha();
        }

        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = url.Replace("{CurrentId}", id.ToString());
            var response = await client.GetAsync(currentUrl);
            string source = null;

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }

        public async Task<string> GetSourceByUrl(string url)
        {
            var response = await client.GetAsync(url);
            string source = null;

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
               
            }
            return source;
        }

        public async Task<string> GetStatusCodeByPageId(int id)
        {
            var currentUrl = url.Replace("{CurrentId}", id.ToString());
            var httpClientHandler = new HttpClientHandler()
            {
                AllowAutoRedirect = false // Отключение автоматической переадресации
            };

            var httpClient = new HttpClient(httpClientHandler);

            var response = await httpClient.GetAsync(currentUrl);

            HttpStatusCode statusCode = response.StatusCode;

            int statusCodeValue = (int)statusCode;

            return statusCodeValue.ToString();
        }
    }
}
