using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Match Participant Frame Informations.
    /// </summary>
    public class MatchParticipantFrameDto
    {
        /// <summary>
        /// Total Gold.
        /// </summary>
        [JsonProperty("totalGold")]
        public int TotalGold { get; set; }

        /// <summary>
        /// Team Score.
        /// </summary>
        [JsonProperty("teamScore")]
        public int TeamScore { get; set; }

        /// <summary>
        /// Participant Id.
        /// </summary>
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        /// <summary>
        /// Level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Current Gold.
        /// </summary>
        [JsonProperty("currentGold")]
        public int CurrentGold { get; set; }

        /// <summary>
        /// Minions Killed.
        /// </summary>
        [JsonProperty("minionsKilled")]
        public int MinionsKilled { get; set; }

        /// <summary>
        /// Dominion Score.
        /// </summary>
        [JsonProperty("dominionScore")]
        public int DominionScore { get; set; }

        /// <summary>
        /// Position.
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; set; }

        /// <summary>
        /// Xp.
        /// </summary>
        [JsonProperty("xp")]
        public int Xp { get; set; }

        /// <summary>
        /// Jungle Minions Killed.
        /// </summary>
        [JsonProperty("jungleMinionsKilled")]
        public int JungleMinionsKilled { get; set; }
    }
}
