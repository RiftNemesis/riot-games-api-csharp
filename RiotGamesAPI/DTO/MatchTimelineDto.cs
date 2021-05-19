using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Match Timeline Informations.
    /// </summary>
    public class MatchTimelineDto
    {
        /// <summary>
        /// Frames.
        /// </summary>
        [JsonProperty("frames")]
        public List<MatchFrameDto> Frames { get; set; }

        /// <summary>
        /// Frame Interval.
        /// </summary>
        [JsonProperty("frameInterval")]
        public long FrameInterval { get; set; }
    }
}
