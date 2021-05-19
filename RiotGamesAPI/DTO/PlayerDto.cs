using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Player information.
    /// </summary>
    public class PlayerDto
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("currentPlatformId")]
        public string CurrentPlatformId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("matchHistoryUri")]
        public string MatchHistoryUri { get; set; }

        /// <summary>
        /// Original platformId.
        /// </summary>
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("currentAccountId")]
        public long CurrentAccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("profileIcon")]
        public int ProfileIcon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }

        /// <summary>
        /// Original accountId.
        /// </summary>
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
    }
}
