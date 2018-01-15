using System;

namespace Parser.Core
{
    class Soccer24Settings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://www.soccer24.com/";
        public int EndPoint { get; set; }
        public string Prefix { get; set; }
        public int StartPoint { get; set; }
    }
}
