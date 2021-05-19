using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// League Position Informations.
    /// </summary>
    public class LeaguePositionDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("queueType")]
        public string QueueType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hotStreak")]
        public bool HotStreak { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("veteran")]
        public bool Veteran { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("leagueName")]
        public string LeagueName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("freshBlood")]
        public bool FreshBlood { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("leagueId")]
        public string LeagueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tier")]
        public string Tier { get; set; }

        /// <summary>
        /// (Between 0 and 100).
        /// </summary>
        [JsonProperty("leaguePoints")]
        public int LeaguePoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("miniSeries")]
        public MiniSeriesDTO MiniSeries { get; set; }
    }
}
