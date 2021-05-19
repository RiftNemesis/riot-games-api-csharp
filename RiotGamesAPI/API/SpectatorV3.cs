using Newtonsoft.Json;
using RiotGamesAPI.DTO;

namespace RiotGamesAPI.API
{
    public class SpectatorV3 : ApiMethod
    {
        public SpectatorV3(ApiConnection apiConnection) : base(apiConnection) { }

        /// <summary>
        /// Get current game information for the given summoner ID.
        /// </summary>
        /// <param name="summonerID">The ID of the summoner.</param>
        public CurrentGameInfo GetCurrentGameInfo(long summonerID)
        {
            string path = string.Format("/lol/spectator/v3/active-games/by-summoner/{0}", summonerID);
            return JsonConvert.DeserializeObject<CurrentGameInfo>(this.ApiConnection.GetResponseAsJson(path));
        }

        /// <summary>
        /// Get list of featured games.
        /// </summary>
        public FeaturedGames GetFeaturedGame()
        {
            string path = "/lol/spectator/v3/featured-games";
            return JsonConvert.DeserializeObject<FeaturedGames>(this.ApiConnection.GetResponseAsJson(path));
        }
    }
}
