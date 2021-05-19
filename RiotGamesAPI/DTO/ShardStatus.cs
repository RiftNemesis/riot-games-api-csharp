using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// League of Legends Status Informations.
    /// </summary>
    public class ShardStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("locales")]
        public List<string> Locales { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("region_tag")]
        public string RegionTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("services")]
        public List<Service> Services { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}
