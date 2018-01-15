using System;

namespace Parser.Core
{
    class Soccer24Settings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://www.soccer24.com/";
        public string Prefix { get; set; }
        public int EndPoint { get; set; } = -1;
        public int StartPoint { get; set; } = -1;
    }
}
