using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Participant information.
    /// </summary>
    public class ParticipantDto
    {
        /// <summary>
        /// Participant statistics.
        /// </summary>
        [JsonProperty("stats")]
        public ParticipantStatsDto Stats { get; set; }

        /// <summary>
        /// First Summoner Spell id.
        /// </summary>
        [JsonProperty("spell1Id")]
        public long Spell1Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        /// <summary>
        /// <para>List of legacy Rune information.</para>
        /// <para>Not included for matches played with Runes Reforged.</para>
        /// </summary>
        [JsonProperty("runes")]
        public List<RuneDto> Runes { get; set; }

        /// <summary>
        /// <para>List of legacy Mastery information.</para>
        /// <para>Not included for matches played with Runes Reforged.</para>
        /// </summary>
        [JsonProperty("masteries")]
        public List<MasteryDto> Masteries { get; set; }

        /// <summary>
        /// Highest ranked tier achieved for the previous season in a specific subset of queueIds, if any, otherwise null. Used to display border in game loading screen. 
        /// Please refer to the Ranked Info documentation.
        /// Legal values: CHALLENGER, MASTER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE, UNRANKED
        /// </summary>
        [JsonProperty("highestAchievedSeasonTier")]
        public string HighestAchievedSeasonTier { get; set; }

        /// <summary>
        /// Second Summoner Spell id.
        /// </summary>
        [JsonProperty("spell2Id")]
        public int Spell2Id { get; set; }

        /// <summary>
        /// 100 for blue side. 200 for red side.
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        /// <summary>
        /// Participant timeline data.
        /// </summary>
        [JsonProperty("timeline")]
        public ParticipantTimelineDto Timeline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("championId")]
        public long ChampionId { get; set; }
    }
}
