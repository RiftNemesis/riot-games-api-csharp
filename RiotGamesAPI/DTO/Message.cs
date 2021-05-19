using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class Message
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_at")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("severity")]
        public string Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("translations")]
        public List<Translation> Translations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("updated_at")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime UpdatedAt { get; set; }
    }
}
