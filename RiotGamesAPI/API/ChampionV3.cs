using Newtonsoft.Json;
using RiotGamesAPI.DTO;

namespace RiotGamesAPI.API
{
    public class ChampionV3 : ApiMethod
    {
        public ChampionV3(ApiConnection apiConnection) : base(apiConnection) { }

        /// <summary>
        /// <para>Returns champion rotations, including free-to-play and low-level free-to-play rotations (REST).</para>
        /// <para>Requests to this API are not counted against the application Rate Limits.</para>
        /// </summary>
        /// <returns></returns>
        public ChampionInfo GetChampionRotations()
        {
            string path = "/lol/platform/v3/champion-rotations";
            return JsonConvert.DeserializeObject<ChampionInfo>(this.ApiConnection.GetResponseAsJson(path));
        }
    }
}
