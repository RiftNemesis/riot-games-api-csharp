using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Team Bans Informations.
    /// </summary>
    public class TeamBansDto
    {
        /// <summary>
        /// Turn during which the champion was banned.
        /// </summary>
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }

        /// <summary>
        /// Banned championId.
        /// </summary>
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
    }
}
