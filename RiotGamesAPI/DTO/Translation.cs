using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class Translation
    {
        /// <summary>
        /// Gets or sets the translation content.
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the translation locale.
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets the last translation update time in UTC.
        /// </summary>
        [JsonProperty("updated_at")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime UpdatedAt { get; set; }
    }
}
