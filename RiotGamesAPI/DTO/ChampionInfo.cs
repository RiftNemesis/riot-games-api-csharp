using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class ChampionInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("freeChampionIds")]
        public List<int> FreeChampionIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("freeChampionIdsForNewPlayers")]
        public List<int> FreeChampionIdsForNewPlayers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("maxNewPlayerLevel")]
        public int MaxNewPlayerLevel { get; set; }
    }
}
