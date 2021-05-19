using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    public class MatchlistDto
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("matches")]
        public List<MatchReferenceDto> Matches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }
    }
}
