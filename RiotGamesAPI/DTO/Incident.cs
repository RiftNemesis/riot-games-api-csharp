using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Incident Informations.
    /// </summary>
    public class Incident
    {
        /// <summary>
        /// Indicates if incident is active or not.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Incident creation time (UTC).
        /// </summary>
        [JsonProperty("created_at")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Incident id.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// List of incident's update messages.
        /// </summary>
        [JsonProperty("updates")]
        public List<Message> Updates { get; set; }
    }
}
