using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Match Infrormations.
    /// </summary>
    public class MatchDto
    {
        /// <summary>
        /// Please refer to the Game Constants documentation.
        /// </summary>
        [JsonProperty("seasonId")]
        public int SeasonId { get; set; }

        /// <summary>
        /// Please refer to the Game Constants documentation.
        /// </summary>
        [JsonProperty("queueId")]
        public int QueueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gameId")]
        public long GameId { get; set; }

        /// <summary>
        /// Participant identity information.
        /// </summary>
        [JsonProperty("participantIdentities")]
        public List<ParticipantIdentityDto> ParticipantIdentities { get; set; }

        /// <summary>
        /// <para>The major.minor version typically indicates</para> 
        /// <para>the patch the match was played on.</para>
        /// </summary>
        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }

        /// <summary>
        /// Platform where the match was played.
        /// </summary>
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        /// <summary>
        /// Please refer to the Game Constants documentation.
        /// </summary>
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        /// <summary>
        /// Please refer to the Game Constants documentation.
        /// </summary>
        [JsonProperty("mapId")]
        public int MapId { get; set; }

        /// <summary>
        /// Please refer to the Game Constants documentation.
        /// </summary>
        [JsonProperty("gameType")]
        public string GameType { get; set; }

        /// <summary>
        /// Team information.
        /// </summary>
        [JsonProperty("teams")]
        public List<TeamStatsDto> Teams { get; set; }

        /// <summary>
        /// Participant information.
        /// </summary>
        [JsonProperty("participants")]
        public List<ParticipantDto> Participants { get; set; }

        /// <summary>
        /// Match duration in seconds.
        /// </summary>
        [JsonProperty("gameDuration")]
        public long GameDuration { get; set; }

        /// <summary>
        /// <para>Designates the timestamp when champion select ended and the</para> 
        /// <para>loading screen appeared, NOT when the game timer was at 0:00.</para>
        /// </summary>
        [JsonProperty("gameCreation")]
        public long GameCreation { get; set; }
    }
}
