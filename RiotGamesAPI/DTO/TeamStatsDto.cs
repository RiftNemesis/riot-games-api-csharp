using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Team information.
    /// </summary>
    public class TeamStatsDto
    {
        /// <summary>
        /// Flag indicating whether or not the team scored the first Dragon kill.
        /// </summary>
        [JsonProperty("firstDragon")]
        public bool FirstDragon { get; set; }

        /// <summary>
        /// If match queueId has a draft, contains banned champion data, otherwise empty.
        /// </summary>
        [JsonProperty("bans")]
        public List<TeamBansDto> Bans { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team destroyed the first inhibitor.
        /// </summary>
        [JsonProperty("firstInhibitor")]
        public bool FirstInhibitor { get; set; }

        /// <summary>
        /// <para>String indicating whether or not the team won.</para>
        /// <para>There are only two values visibile in public match history.</para>
        /// <para>Legal values: Fail, Win</para>
        /// </summary>
        [JsonProperty("win")]
        public string Win { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team scored the first Rift Herald kill.
        /// </summary>
        [JsonProperty("firstRiftHerald")]
        public bool FirstRiftHerald { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team scored the first Baron kill.
        /// </summary>
        [JsonProperty("firstBaron")]
        public bool FirstBaron { get; set; }

        /// <summary>
        /// Number of times the team killed Baron.
        /// </summary>
        [JsonProperty("baronKills")]
        public int BaronKills { get; set; }

        /// <summary>
        /// Number of times the team killed Rift Herald.
        /// </summary>
        [JsonProperty("riftHeraldKills")]
        public int RiftHeraldKills { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team scored the first blood.
        /// </summary>
        [JsonProperty("firstBlood")]
        public bool FirstBlood { get; set; }

        /// <summary>
        /// 100 for blue side. 200 for red side.
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team destroyed the first tower.
        /// </summary>
        [JsonProperty("firstTower")]
        public bool FirstTower { get; set; }

        /// <summary>
        /// Number of times the team killed Vilemaw.
        /// </summary>
        [JsonProperty("vilemawKills")]
        public int VilemawKills { get; set; }

        /// <summary>
        /// Number of inhibitors the team destroyed.
        /// </summary>
        [JsonProperty("inhibitorKills")]
        public int InhibitorKills { get; set; }

        /// <summary>
        /// Number of towers the team destroyed.
        /// </summary>
        [JsonProperty("towerKills")]
        public int TowerKills { get; set; }

        /// <summary>
        /// For Dominion matches, specifies the points the team had at game end.
        /// </summary>
        [JsonProperty("dominionVictoryScore")]
        public int DominionVictoryScore { get; set; }

        /// <summary>
        /// Number of times the team killed Dragon.
        /// </summary>
        [JsonProperty("dragonKills")]
        public int DragonKills { get; set; }
    }
}
