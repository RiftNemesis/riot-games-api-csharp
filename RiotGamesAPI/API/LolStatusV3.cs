using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using RiotGamesAPI.DTO;

namespace RiotGamesAPI.API
{
    public class LolStatusV3 : ApiMethod
    {
        public LolStatusV3(ApiConnection apiConnection) : base(apiConnection) { }

        /// <summary>
        /// <para>Get League of Legends status for the given shard.</para>
        /// <para>Requests to this API are not counted against the application Rate Limits.</para>
        /// </summary>
        /// <returns>ShardStatus</returns>
        public ShardStatus GetLeagueOfLegendsStatus()
        {
            string path = string.Format("/lol/status/v3/shard-data");
            return JsonConvert.DeserializeObject<ShardStatus>(this.ApiConnection.GetResponseAsJson(path));
        }
    }
}
