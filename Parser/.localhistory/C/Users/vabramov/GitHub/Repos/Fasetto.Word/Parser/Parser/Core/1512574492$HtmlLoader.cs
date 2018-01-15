using System.Net.Http;
using System.Threading.Tasks;
using System.Net;

namespace Parser.Core
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            //url = $"{ settings.BaseUrl}/{ settings.Prefix}/";
            url = $"{ settings.BaseUrl}/";
        }

        public async Task<string> GetSourceByPageId(int id = -1)
        {

            var currentUrl = url;
            if (id == -1)
            {
                currentUrl = url.Replace("{CurrentId}", id.ToString());
            }

            var response = await client.GetAsync(currentUrl);
            string source = null;

            if(response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }
            return source;
        }        
    }
}
