
namespace ParserKupiProday.Core.KupiProday
{
    internal class KPSettings : IParserSettings
    {
        public KPSettings(int start, int end, string category, string linksPath, string dataPath, string subCategory, string oblast)
        {
            StartPoint = start;
            EndPoint = end;
            Prefix = category;
            SubPrefix = subCategory;
            Sufix = oblast;
            LinksPathSave = linksPath;
            DataPathSave = dataPath;
        }

        public string BaseUrl { get; set; } = "kupiprodai.ru";
        public string Prefix { get; set; } 
        public string SubPrefix { get; set; }
        public string Sufix { get; set; }
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
        public string LinkUrl { get; set; } = "{LinkId}";
        public string LinksPathSave { get; set; }
        public string DataPathSave { get; set;}
    }
    //{CurrentId}
}
