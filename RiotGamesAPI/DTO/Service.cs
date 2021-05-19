using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Service Informations.
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Gets or sets list of service incidents.
        /// </summary>
        [JsonProperty("incidents")]
        public List<Incident> Incidents { get; set; }

        /// <summary>
        /// Gets or sets the service name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the service tag name.
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets service status. This should equal one of the <see cref="ServerStatus"/> values.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
