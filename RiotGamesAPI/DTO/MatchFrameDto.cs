using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Match Frame Informations.
    /// </summary>
    public class MatchFrameDto
    {
        /// <summary>
        /// Timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }	
        
        /// <summary>
        /// Participant Frames.
        /// </summary>
        [JsonProperty("participantFrames")]
        public Dictionary<int, MatchParticipantFrameDto> ParticipantFrames { get; set; }		

        /// <summary>
        /// Events.
        /// </summary>
        [JsonProperty("events")]	
        public List<MatchEventDto> Events { get; set; }	
    }
}
