using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Game Customization.
    /// </summary>
    public class GameCustomizationObject
    {
        /// <summary>
        /// Category identifier for Game Customization.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Game Customization content.
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
