
namespace Parser.Core
{
    class HabraSettings : IParserSettings
    {
        public HabraSettings(int p_start, int p_end)
        {
            StartPoint = p_start;
            EndPoint = p_end;
        }

        public string BaseUrl { get; set; } = "https://habrahabr.ru";
        public string Prefix { get; set; } = "page{CurrentId}";
        public int EndPoint { get; set; } 
        public int StartPoint { get; set; }
    }
}
