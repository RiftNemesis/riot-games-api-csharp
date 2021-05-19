using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Featured Games.
    /// </summary>
    public class FeaturedGames
    {
        /// <summary>
        /// The suggested interval to wait before requesting FeaturedGames again.
        /// </summary>
        [JsonProperty("clientRefreshInterval")]
        public long ClientRefreshInterval { get; set; }

        /// <summary>
        /// The list of featured games.
        /// </summary>
        [JsonProperty("gameList")]
        public List<FeaturedGameInfo> GameList { get; set; }
    }
}
