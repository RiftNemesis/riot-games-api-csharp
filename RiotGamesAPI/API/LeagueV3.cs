using Newtonsoft.Json;
using RiotGamesAPI.DTO;
using System.Collections.Generic;

namespace RiotGamesAPI.API
{
    public class LeagueV3 : ApiMethod
    {
        public LeagueV3(ApiConnection apiConnection) : base(apiConnection) { }

        /// <summary>
        /// Get the challenger league for given queue.
        /// </summary>
        /// <param name="queue">Queue Type.</param>
        /// <returns>LeagueListDTO</returns>
        public LeagueListDTO GetChallengerLeague(string queue)
        {
            string path = string.Format("/lol/league/v3/challengerleagues/by-queue/{0}", queue);
            return JsonConvert.DeserializeObject<LeagueListDTO>(this.ApiConnection.GetResponseAsJson(path));
        }

        /// <summary>
        /// <para>Get league with given ID, including inactive entries.</para>
        /// <para>Consistently looking up leagueIds that don't exist will result in a blacklist.</para>
        /// </summary>
        /// <param name="leagueId">The UUID of the league.</param>
        /// <returns>LeagueListDTO</returns>
        public LeagueListDTO GetLeague(string leagueId)
        {
            string path = string.Format("/lol/league/v3/leagues/{0}", leagueId);
            return JsonConvert.DeserializeObject<LeagueListDTO>(this.ApiConnection.GetResponseAsJson(path));
        }

        /// <summary>
        /// Get the master league for given queue.
        /// </summary>
        /// <param name="queue">Queue Type.</param>
        /// <returns>LeagueListDTO</returns>
        public LeagueListDTO GetMasterLeague(string queue)
        {
            string path = string.Format("/lol/league/v3/masterleagues/by-queue/{0}", queue);
            return JsonConvert.DeserializeObject<LeagueListDTO>(this.ApiConnection.GetResponseAsJson(path));
        }

        /// <summary>
        /// Get league positions in all queues for a given summoner ID.
        /// </summary>
        /// <param name="summonerId">Summoner ID</param>
        /// <returns>List<LeaguePositionDTO></returns>
        public List<LeaguePositionDTO> GetLeaguePositions(long summonerId)
        {
            string path = string.Format("/lol/league/v3/positions/by-summoner/{0}", summonerId);
            return JsonConvert.DeserializeObject<List<LeaguePositionDTO>>(this.ApiConnection.GetResponseAsJson(path));
        }
    }
}
