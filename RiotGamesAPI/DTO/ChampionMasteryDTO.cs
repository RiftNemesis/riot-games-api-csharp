using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// This object contains single Champion Mastery information for player and champion combination.
    /// </summary>
    public class ChampionMasteryDTO
    {
        /// <summary>
        /// Champion level for specified player and champion combination.
        /// </summary>
        [JsonProperty("championLevel")]
        public int ChampionLevel { get; set; }

        /// <summary>
        /// Is chest granted for this champion or not in current season.
        /// </summary>
        [JsonProperty("chestGranted")]
        public bool ChestGranted { get; set; }

        /// <summary>
        /// <para>Total number of champion points for this player and champion combination.</para>
        /// <para>They are used to determine championLevel.</para>
        /// </summary>
        [JsonProperty("championPoints")]
        public int ChampionPoints { get; set; }

        /// <summary>
        /// Number of points earned since current level has been achieved.
        /// </summary>
        [JsonProperty("championPointsSinceLastLevel")]
        public long ChampionPointsSinceLastLevel { get; set; }

        /// <summary>
        /// Player ID for this entry.
        /// </summary>
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }

        /// <summary>
        /// <para>Number of points needed to achieve next level.</para> 
        /// <para>Zero if player reached maximum champion level for this champion.</para>
        /// </summary>
        [JsonProperty("championPointsUntilNextLevel")]
        public long ChampionPointsUntilNextLevel { get; set; }

        /// <summary>
        /// The token earned for this champion to levelup.
        /// </summary>
        [JsonProperty("tokensEarned")]
        public int TokensEarned { get; set; }

        /// <summary>
        /// Champion ID for this entry.
        /// </summary>
        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        /// <summary>
        /// <para>Last time this champion was played by this player.</para>
        /// </para>In Unix milliseconds time format.</para>
        /// </summary>
        [JsonProperty("lastPlayTime")]
        public long LastPlayTime { get; set; }
    }
}
