﻿using AngleSharp.Dom.Html;
using System.Collections.Generic;
using System.Linq;

namespace Parser.Core
{
    class Soccer24Parser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();

            var items = document.QuerySelectorAll("tr")
                .Where(item => item.ClassName != null
                                && item.ClassName.Contains("cell_ab team-home > padl"));

            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
