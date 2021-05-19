using System.IO;
using System.Net;

namespace RiotGamesAPI
{
    public class ApiConnection
    {
        public enum RegionCode { br1, eun1, euw1, jp1, kr, la1, la2, na1, oc1, tr1, ru, pbe1, americas, europe, asia }
        public string ApiKey { get; set; }
        public RegionCode Region { get; set; }
        
        public ApiConnection(string apiKey, RegionCode region)
        {
            this.ApiKey = apiKey;
            this.Region = region;
        }

        public string GetResponseAsJson(string path)
        {
            string url = string.Format("https://{0}.api.riotgames.com", Region.ToString()) + path;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Origin", "https://developer.riotgames.com");
            request.Headers.Add("Accept-Charset", "application/x-www-form-urlencoded; charset=UTF-8");
            request.Headers.Add("X-Riot-Token", this.ApiKey);
            request.Headers.Add("Accept-Language", "fr-FR,fr;q=0.9,en-US;q=0.8,en;q=0.7");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return (new StreamReader(response.GetResponseStream())).ReadToEnd();
        }
    }
}
