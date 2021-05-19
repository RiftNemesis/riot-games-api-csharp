using Newtonsoft.Json;

namespace RiotGamesAPI.API
{
    public class ThirdPartyCodeV3 : ApiMethod
    {
        public ThirdPartyCodeV3(ApiConnection apiConnection) : base(apiConnection) { }

        /// <summary>
        /// <para>Get third party code for a given summoner ID.</para>
        /// <para>Valid codes must be : </para>
        /// <para>• No longer than 256 characters.</para> 
        /// <para>• Only use valid characters (0-9, a-z, A-Z, -).</para>
        /// </summary>
        /// <param name="summonerId"></param>
        /// <returns></returns>
        public string GetThirdPartyCode(long summonerId)
        {
            string path = string.Format("/lol/platform/v3/third-party-code/by-summoner/{0}", summonerId);
            return JsonConvert.DeserializeObject<string>(this.ApiConnection.GetResponseAsJson(path));
        }
    }
}
