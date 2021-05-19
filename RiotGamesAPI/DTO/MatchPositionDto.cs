using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Match Position Informations.
    /// </summary>
    public class MatchPositionDto
    {
        /// <summary>
        /// X Coordinate.
        /// </summary>
        [JsonProperty("x")]
        public int X { get; set; }

        /// <summary>
        /// Y Coordinate.
        /// </summary>
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}
