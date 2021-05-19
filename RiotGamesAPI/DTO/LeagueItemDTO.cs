using System.Collections.Generic;
using Newtonsoft.Json;


namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class LeagueItemDTO
    {
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
        [JsonProperty("rank")]
        public string Rank { get; set; }

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
        [JsonProperty("playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("freshBlood")]
        public bool FreshBlood { get; set; }

        /// <summary>
        /// 
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
