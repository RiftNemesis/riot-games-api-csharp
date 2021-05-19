using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Mini Series Informations. 
    /// </summary>
    public class MiniSeriesDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target")]
        public int Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("progress")]
        public string Progress { get; set; }
    }
}
