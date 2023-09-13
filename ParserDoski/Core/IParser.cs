using AngleSharp.Html.Dom;

namespace ParserKupiProday.Core.Core
{
    internal interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document, string linksPathSave);
        T LinkParser(IHtmlDocument document, string dataPathSave, string oblast);
    }
}
