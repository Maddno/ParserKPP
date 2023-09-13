
namespace ParserKupiProday.Core
{
    internal interface IParserSettings
    {
        string BaseUrl { get; set; }
        string Prefix { get; set; }
        string SubPrefix { get; set; }
        string Sufix { get; set; }
        int StartPoint { get; set; }
        int EndPoint { get; set; }
        string LinkUrl { get; set; }
        string LinksPathSave { get; set; }
        string DataPathSave { get; set; }
    }
}
