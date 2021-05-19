using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Participant identity information.
    /// </summary>
    public class ParticipantIdentityDto
    {
        /// <summary>
        /// Player information.
        /// </summary>
        [JsonProperty("player")]
        public PlayerDto Player { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
    }
}
