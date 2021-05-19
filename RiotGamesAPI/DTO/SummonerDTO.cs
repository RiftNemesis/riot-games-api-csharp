using System;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    [Serializable]
    /// <summary>
    /// Represents a summoner.
    /// </summary>
    public partial class SummonerDTO
    {
        /// <summary>
        /// ID of the summoner icon associated with the summoner.
        /// </summary>
        [JsonProperty("profileIconId")]
        public long ProfileIconId { get; set; }

        /// <summary>
        /// Summoner name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Summoner level associated with the summoner.
        /// </summary>
        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }

        /// <summary>
        /// Account ID.
        /// </summary>
        [JsonProperty("accountId")]
        public long AccountId { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Date summoner was last modified specified as epoch milliseconds. 
        /// <para>The following events will update this timestamp :</para>
        /// <para>• Profile icon change.</para>
        /// <para>• Playing the tutorial or advanced tutorial.</para>
        /// <para>• Finishing a game,</para> 
        /// <para>• Summoner name change.</para>
        /// </summary>
        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }
    }
}
