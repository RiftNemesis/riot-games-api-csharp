using System.Collections.Generic;
using Newtonsoft.Json;
using RiotGamesAPI.DTO;

namespace RiotGamesAPI.API
{
    public class ChampionMasteryV3 : ApiMethod
    {
        public ChampionMasteryV3(ApiConnection apiConnection) : base(apiConnection) { }

        /// <summary>
        /// Get all champion mastery entries sorted by number of champion points descending.
        /// </summary>
        /// <param name="summonerId">Summoner ID associated with the player.</param>
        /// <returns>List<ChampionMasteryDTO></returns>
        public List<ChampionMasteryDTO> GetAllChampionMasteryEntries(long summonerId)
        {
            string path = string.Format("/lol/champion-mastery/v3/champion-masteries/by-summoner/{0}", summonerId);
            return JsonConvert.DeserializeObject<List<ChampionMasteryDTO>>(this.ApiConnection.GetResponseAsJson(path));
        }

        /// <summary>
        /// Get a champion mastery by player ID and champion ID.
        /// </summary>
        /// <param name="summonerId">Summoner ID associated with the player.</param>
        /// <param name="championId">Champion ID to retrieve Champion Mastery for.</param>
        /// <returns>ChampionMasteryDTO</returns>
        public ChampionMasteryDTO GetChampionMastery(long summonerId, long championId)
        {
            string path = string.Format("/lol/champion-mastery/v3/champion-masteries/by-summoner/{0}/by-champion/{1}", summonerId, championId);
            return JsonConvert.DeserializeObject<ChampionMasteryDTO>(this.ApiConnection.GetResponseAsJson(path));
        }

        /// <summary>
        /// Get a player's total champion mastery score, which is the sum of individual champion mastery levels.
        /// </summary>
        /// <param name="summonerId">Summoner ID associated with the player.</param>
        /// <returns>int</returns>
        public int GetTotalChampionMasteryScore(long summonerId)
        {
            string path = string.Format("/lol/champion-mastery/v3/scores/by-summoner/{0}", summonerId);
            return JsonConvert.DeserializeObject<int>(this.ApiConnection.GetResponseAsJson(path));
        }
    }
}
