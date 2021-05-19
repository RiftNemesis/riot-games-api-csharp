using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Lobby Event Informations.
    /// </summary>
    public class LobbyEventDTO
    {
        /// <summary>
        /// The type of event that was triggered.
        /// </summary>
        [JsonProperty("eventType")]
        public string eventType { get; set; }

        /// <summary>
        /// The summoner that triggered the event.
        /// </summary>
        [JsonProperty("summonerId")]
        public string summonerId { get; set; }

        /// <summary>
        /// Timestamp from the event.
        /// </summary>
        [JsonProperty("timestamp")]
        public string timestamp { get; set; }
    }
}
