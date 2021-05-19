using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Mastery Informations.
    /// </summary>
    public class MasteryDto
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("masteryId")]
        public int masteryId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rank")]
        public int rank { get; set; }
    }
}
