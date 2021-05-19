using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Rune Informations.
    /// </summary>
    public class RuneDto
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("runeId")]
        public int RuneId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
