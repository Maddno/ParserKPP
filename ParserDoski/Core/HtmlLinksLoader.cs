using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using AngleSharp.Html.Parser;
using AngleSharp.Html.Dom;
using System.Linq;

namespace ParserKupiProday.Core
{
    internal class HtmlLinksLoader
    {
        readonly HttpClient client;
        readonly string linkUrl;
        readonly string oblast;

        public HtmlLinksLoader(IParserSettings settings)
        {
            client = new HttpClient();
            linkUrl = settings.LinkUrl;
            oblast = settings.Sufix;
        }

        public async Task<string> GetSourceByLinkId(string id)
        {
            var currentUrl = linkUrl.Replace("{LinkId}", id.ToString());
            await GetSourceByUrl($"{oblast}kupiprodai.ru/mobile/1/");
            return await GetSourceByUrl(currentUrl);
        }
        public async Task<string> GetSourceByUrl(string url)
        {
            var response = await client.GetAsync(url);
            string source = null;

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await  response.Content.ReadAsStringAsync();
            }
            return source;
        }
    }
}
