using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Participant Timeline Informations.
    /// </summary>
    public class ParticipantTimelineDto
    {
        /// <summary>
        /// <para>Participant's calculated lane. MID and BOT are legacy values.</para>
        /// <para>Legal values: MID, MIDDLE, TOP, JUNGLE, BOT, BOTTOM.</para>
        /// </summary>
        [JsonProperty("lane")]
        public string Lane { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        /// <summary>
        /// <para>Participant's calculated role.</para>
        /// <para>Legal values: DUO, NONE, SOLO, DUO_CARRY, DUO_SUPPORT</para>
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <summary>
        /// Creep score difference versus the calculated 
        /// lane opponent(s) for a specified period.
        /// </summary>
        [JsonProperty("csDiffPerMinDeltas")]
        public Dictionary<string, double> CsDiffPerMinDeltas { get; set; }

        /// <summary>
        /// Gold for a specified period.
        /// </summary>
        [JsonProperty("goldPerMinDeltas")]
        public Dictionary<string, double> GoldPerMinDeltas { get; set; }

        /// <summary>
        /// Experience difference versus the calculated 
        /// lane opponent(s) for a specified period.
        /// </summary>
        [JsonProperty("xpDiffPerMinDeltas")]
        public Dictionary<string, double> XpDiffPerMinDeltas { get; set; }

        /// <summary>
        /// Creeps for a specified period.
        /// </summary>
        [JsonProperty("creepsPerMinDeltas")]
        public Dictionary<string, double> CreepsPerMinDeltas { get; set; }

        /// <summary>
        /// Experience change for a specified period.
        /// </summary>
        [JsonProperty("xpPerMinDeltas")]
        public Dictionary<string, double> XpPerMinDeltas { get; set; }

        /// <summary>
        /// Damage taken difference versus the calculated 
        /// lane opponent(s) for a specified period.
        /// </summary>
        [JsonProperty("damageTakenDiffPerMinDeltas")]
        public Dictionary<string, double> DamageTakenDiffPerMinDeltas { get; set; }

        /// <summary>
        /// Damage taken for a specified period.
        /// </summary>
        [JsonProperty("damageTakenPerMinDeltas")]
        public Dictionary<string, double> DamageTakenPerMinDeltas { get; set; }
    }
}
