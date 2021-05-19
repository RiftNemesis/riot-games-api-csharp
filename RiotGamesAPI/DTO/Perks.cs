using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Perks/Runes Reforged Information.
    /// </summary>
    public class Perks
    {
        /// <summary>
        /// Primary runes path.
        /// </summary>
        [JsonProperty("perkStyle")]
        public long PerkStyle { get; set; }

        /// <summary>
        /// IDs of the perks/runes assigned.
        /// </summary>
        [JsonProperty("perkIds")]
        public List<long> PerkIds { get; set; }

        /// <summary>
        /// Secondary runes path.
        /// </summary>
        [JsonProperty("perkSubStyle")]
        public int PerkSubStyle { get; set; }

        public override string ToString()
        {
            string perkIdsStr = string.Empty;
            foreach (long perkId in PerkIds)
            {
                perkIdsStr += perkId + " " + System.Environment.NewLine;
            }
            return string.Format("Perk Style : {1} {0}Perk Sub Style : {2} {0}Perk IDs : {0}{3}", 
                System.Environment.NewLine, PerkStyle, PerkSubStyle, perkIdsStr);
        }
    }
}
