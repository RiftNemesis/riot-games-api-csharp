using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// League List Informations.
    /// </summary>
    public class LeagueListDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tier")]
        public string Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("queue")]
        public string Queue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("leagueId")]
        public string LeagueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("entries")]
        public List<LeagueItemDTO> Entries { get; set; }
    }
}
