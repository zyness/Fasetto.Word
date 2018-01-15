﻿using AngleSharp;
using AngleSharp.Parser.Html;
using System;
using System.Threading.Tasks;

namespace Parser.Core
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;

        HtmlLoader loader;
        bool isActive;


        #region Properties

        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserSettings Settings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }
        #endregion


        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;
        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }

        private async void Worker()
        {
            if(parserSettings.StartPoint >= 0 || parserSettings.EndPoint >= 0)
            {
                for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
                {
                    if (!isActive)
                    {
                        OnCompleted?.Invoke(this);
                        return;
                    }


                    var source = await loader.GetSourceByPageId(i);

                    var domParser = new HtmlParser();

                    var document = await domParser.ParseAsync(source);

                    var result = parser.Parse(document);

                    OnNewData?.Invoke(this, result);
                }
            }
            else
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }
                var source = await loader.GetSourceByPageId();

                var domParser = new HtmlParser();

                var config = new Configuration().WithDefaultLoader();

                var document = await BrowsingContext.New(config).OpenAsync(Url.Create(source));

                var document1 = await domParser.ParseAsync(source);                

                var result = parser.Parse(document1);

                OnNewData?.Invoke(this, result);
            }
            OnCompleted?.Invoke(this);
            isActive = false;
        }

    }
}
