using System.Text.RegularExpressions;
using Newtonsoft.Json;
using RiotGamesAPI.DTO;

namespace RiotGamesAPI.API
{
    public class SummonerV3 : ApiMethod
    {
        public SummonerV3(ApiConnection apiConnection) : base(apiConnection) {}

        /// <summary>
        /// Get a summoner by account ID.
        /// </summary>
        /// <param name="accountID">Account ID.</param>
        /// <returns>SummonerDTO</returns>
        public SummonerDTO GetSummonerByAccountID(long accountID)
        {
            string path = string.Format("/lol/summoner/v3/summoners/by-account/{0}", accountID);
            return JsonConvert.DeserializeObject<SummonerDTO>(this.ApiConnection.GetResponseAsJson(path));
        }

        /// <summary>
        /// Get a summoner by summoner name.
        /// </summary>
        /// <param name="summonerName">Summoner name.</param>
        /// <returns>SummonerDTO</returns>
        public SummonerDTO GetSummonerBySummonerName(string summonerName)
        {
            string path = string.Format("/lol/summoner/v3/summoners/by-name/{0}", summonerName);
            return JsonConvert.DeserializeObject<SummonerDTO>(this.ApiConnection.GetResponseAsJson(path));
        }

        /// <summary>
        /// Get a summoner by summoner ID.
        /// <para>♦ Consistently looking up summonerIds that don't exist will result in a blacklist.</para>
        /// </summary>
        /// <param name="SummonerID">Summoner ID.</param>
        /// <returns>SummonerDTO</returns>
        public SummonerDTO GetSummonerBySummonerID(long SummonerID)
        {
            string path = string.Format("/lol/summoner/v3/summoners/{0}", SummonerID);
            return JsonConvert.DeserializeObject<SummonerDTO>(this.ApiConnection.GetResponseAsJson(path));
        }

        /// <summary>
        /// <para>Checks if a summoner name contains valid charaters.</para>
        /// <para>The full set of allowed characters across Riot, Tencent, and Garena regions includes :</para> 
        /// <para>Any visible Unicode letter characters, digits (0-9), spaces, underscores, and periods.</para>
        /// <para>Other than that, no punctuation characters are allowed.</para> 
        /// </summary>
        /// <param name="summonerName"></param>
        /// <returns></returns>
        public static bool IsSummonerNameValid(string summonerName)
        {
            return Regex.IsMatch(summonerName, "^[0-9\\p{L} _\\.]+$");
        }
    }
}
