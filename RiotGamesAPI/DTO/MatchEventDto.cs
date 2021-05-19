using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    public class MatchEventDto
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eventType")]
        public string eventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("towerType")]
        public string towerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("teamId")]
        public int teamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ascendedType")]
        public string ascendedType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("killerId")]
        public int killerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("levelUpType")]
        public string levelUpType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pointCaptured")]
        public string pointCaptured { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assistingParticipantIds")]
        public List<int> assistingParticipantIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("wardType")]
        public string wardType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("monsterType")]
        public string monsterType { get; set; }

        /// <summary>
        /// <para>Legal values:</para>
        /// <para>CHAMPION_KILL, WARD_PLACED, WARD_KILL,</para>
        /// <para>BUILDING_KILL, ELITE_MONSTER_KILL, ITEM_PURCHASED,</para>
        /// <para>ITEM_SOLD, ITEM_DESTROYED, ITEM_UNDO, SKILL_LEVEL_UP,</para>
        /// <para>ASCENDED_EVENT, CAPTURE_POINT, PORO_KING_SUMMON)</para>
        /// </summary>
        [JsonProperty("type")]
        public string type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("skillSlot")]
        public int skillSlot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("victimId")]
        public int victimId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("timestamp")]
        public long timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("afterId")]
        public int afterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("monsterSubType")]
        public string monsterSubType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("laneType")]
        public string laneType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("itemId")]
        public int itemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("participantId")]
        public int participantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("buildingType")]
        public string buildingType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creatorId")]
        public int creatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("position")]
        public MatchPositionDto position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("beforeId")]
        public int beforeId { get; set; }
    }
}
