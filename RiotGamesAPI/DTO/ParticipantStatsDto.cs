using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Participant Stats Informations.
    /// </summary>
    public class ParticipantStatsDto
    {
        /// <summary>
        /// First Blood Kill.	
        /// </summary>
        [JsonProperty("firstBloodKill")]
        public bool FirstBloodKill { get; set; }

        /// <summary>
        /// First Blood Assist.	
        /// </summary>
        [JsonProperty("firstBloodAssist")]
        public bool FirstBloodAssist { get; set; }

        /// <summary>
        /// Neutral Minions Killed Team Jungle.
        /// </summary>
        [JsonProperty("neutralMinionsKilledTeamJungle")]
        public int NeutralMinionsKilledTeamJungle { get; set; }

        /// <summary>
        /// Node Neutralize.
        /// </summary>
        [JsonProperty("nodeNeutralize")]
        public int NodeNeutralize { get; set; }

        /// <summary>
        /// Node Neutralize Assist.
        /// </summary>
        [JsonProperty("nodeNeutralizeAssist")]
        public int NodeNeutralizeAssist { get; set; }

        /// <summary>
        /// Node Capture.
        /// </summary>
        [JsonProperty("nodeCapture")]
        public int NodeCapture { get; set; }

        /// <summary>
        /// Node Capture Assist.
        /// </summary>
        [JsonProperty("nodeCaptureAssist")]
        public int NodeCaptureAssist { get; set; }
        
        /// <summary>
        /// Vision Score.
        /// </summary>
        [JsonProperty("visionScore")]
        public long VisionScore { get; set; }

        /// <summary>
        /// Magic Damage Dealt To Champions.
        /// </summary>
        [JsonProperty("magicDamageDealtToChampions")]
        public long MagicDamageDealtToChampions { get; set; }

        /// <summary>
        /// Largest MultiKill.
        /// </summary>
        [JsonProperty("largestMultiKill")]
        public int LargestMultiKill { get; set; }

        /// <summary>
        /// Total Time Crowd Control Dealt.
        /// </summary>
        [JsonProperty("totalTimeCrowdControlDealt")]
        public int TotalTimeCrowdControlDealt { get; set; }

        /// <summary>
        /// Longest Time Spent Living.
        /// </summary>
        [JsonProperty("longestTimeSpentLiving")]
        public int LongestTimeSpentLiving { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk1Var1")]
        public int Perk1Var1 { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk1Var2")]
        public int Perk1Var2 { get; set; }
        
        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk1Var3")]
        public int Perk1Var3 { get; set; }

        /// <summary>
        /// Tiple Kills.
        /// </summary>
        [JsonProperty("tripleKills")]
        public int TripleKills { get; set; }

        /// <summary>
        /// Secondary path rune.
        /// </summary>
        [JsonProperty("perk5")]
        public int Perk5 { get; set; }

        /// <summary>
        /// Secondary path rune.
        /// </summary>
        [JsonProperty("perk4")]
        public int Perk4 { get; set; }

        /// <summary>
        /// player Score 9.	
        /// </summary>
        [JsonProperty("playerScore9")]
        public int PlayerScore9 { get; set; }

        /// <summary>
        /// player Score 8.
        /// </summary>
        [JsonProperty("playerScore8")]
        public int PlayerScore8 { get; set; }

        /// <summary>
        /// Kills.
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; set; }

        /// <summary>
        /// player Score 1.
        /// </summary>
        [JsonProperty("playerScore1")]
        public int PlayerScore1 { get; set; }

        /// <summary>
        /// Player Score 0.
        /// </summary>
        [JsonProperty("playerScore0")]
        public int PlayerScore0 { get; set; }

        /// <summary>
        /// Player Score 3.
        /// </summary>
        [JsonProperty("playerScore3")]
        public int PlayerScore3 { get; set; }

        /// <summary>
        /// Player Score 2.
        /// </summary>
        [JsonProperty("playerScore2")]
        public int PlayerScore2 { get; set; }
        
        /// <summary>
        /// Player Score 5.
        /// </summary>
        [JsonProperty("playerScore5")]
        public int PlayerScore5 { get; set; }

        /// <summary>
        /// Player Score 4.
        /// </summary>
        [JsonProperty("playerScore4")]
        public int PlayerScore4 { get; set; }

        /// <summary>
        /// Player Score 7.
        /// </summary>
        [JsonProperty("playerScore7")]
        public int PlayerScore7 { get; set; }

        /// <summary>
        /// Player Score 6.
        /// </summary>
        [JsonProperty("playerScore6")]
        public int PlayerScore6 { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk5Var1")]
        public int Perk5Var1 { get; set; }
        
        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk5Var3")]
        public int Perk5Var3 { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk5Var2")]
        public int Perk5Var2 { get; set; }

        /// <summary>
        /// Total Score Rank.
        /// </summary>
        [JsonProperty("totalScoreRank")]
        public int TotalScoreRank { get; set; }

        /// <summary>
        /// Neutral Minions Killed.
        /// </summary>
        [JsonProperty("neutralMinionsKilled")]
        public int NeutralMinionsKilled { get; set; }

        /// <summary>
        /// Damage Dealt To Turrets.
        /// </summary>
        [JsonProperty("damageDealtToTurrets")]
        public long DamageDealtToTurrets { get; set; }

        /// <summary>
        /// Physical Damage Dealt To Champions.
        /// </summary>
        [JsonProperty("physicalDamageDealtToChampions")]
        public long PhysicalDamageDealtToChampions { get; set; }

        /// <summary>
        /// Damage Dealt To Objectives.
        /// </summary>
        [JsonProperty("damageDealtToObjectives")]
        public long DamageDealtToObjectives { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk2Var2")]
        public int Perk2Var2 { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk2Var3")]
        public int Perk2Var3 { get; set; }

        /// <summary>
        /// Total Units Healed.
        /// </summary>
        [JsonProperty("totalUnitsHealed")]
        public int TotalUnitsHealed { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk2Var1")]
        public int Perk2Var1 { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk4Var1")]
        public int Perk4Var1 { get; set; }

        /// <summary>
        /// Total Damage Taken.
        /// </summary>
        [JsonProperty("totalDamageTaken")]
        public long TotalDamageTaken { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk4Var3")]
        public int Perk4Var3 { get; set; }

        /// <summary>
        /// Wards Killed.
        /// </summary>
        [JsonProperty("wardsKilled")]
        public int WardsKilled { get; set; }

        /// <summary>
        /// Largest Critical Strike.
        /// </summary>
        [JsonProperty("largestCriticalStrike")]
        public int LargestCriticalStrike { get; set; }

        /// <summary>
        /// Largest Killing Spree.
        /// </summary>
        [JsonProperty("largestKillingSpree")]
        public int LargestKillingSpree { get; set; }

        /// <summary>
        /// QuadraKills.
        /// </summary>
        [JsonProperty("quadraKills")]
        public int QuadraKills { get; set; }

        /// <summary>
        /// Team Objective.
        /// </summary>
        [JsonProperty("teamObjective")]
        public int TeamObjective { get; set; }

        /// <summary>
        /// Magic Damage Dealt.
        /// </summary>
        [JsonProperty("magicDamageDealt")]
        public long MagicDamageDealt { get; set; }

        /// <summary>
        /// Item 2.
        /// </summary>
        [JsonProperty("item2")]
        public int Item2 { get; set; }

        /// <summary>
        /// Item 3.
        /// </summary>
        [JsonProperty("item3")]
        public int Item3 { get; set; }

        /// <summary>
        /// Item 0.
        /// </summary>
        [JsonProperty("item0")]
        public int Item0 { get; set; }

        /// <summary>
        /// Item 1.
        /// </summary>
        [JsonProperty("item1")]
        public int Item1 { get; set; }

        /// <summary>
        /// Item 6.
        /// </summary>
        [JsonProperty("item6")]
        public int Item6 { get; set; }

        /// <summary>
        /// Item 4.
        /// </summary>
        [JsonProperty("item4")]
        public int Item4 { get; set; }

        /// <summary>
        /// Item 5.
        /// </summary>
        [JsonProperty("item5")]
        public int Item5 { get; set; }

        /// <summary>
        /// Primary path rune.
        /// </summary>
        [JsonProperty("perk1")]
        public int Perk1 { get; set; }

        /// <summary>
        /// Primary path keystone rune.
        /// </summary>
        [JsonProperty("perk0")]
        public int Perk0 { get; set; }

        /// <summary>
        /// Primary path rune.
        /// </summary>
        [JsonProperty("perk3")]
        public int Perk3 { get; set; }

        /// <summary>
        /// Primary path rune.
        /// </summary>
        [JsonProperty("perk2")]
        public int Perk2 { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk3Var3")]
        public int Perk3Var3 { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk3Var2")]
        public int Perk3Var2 { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk3Var1")]
        public int Perk3Var1 { get; set; }

        /// <summary>
        /// Damage Self Mitigated.
        /// </summary>
        [JsonProperty("damageSelfMitigated")]
        public long DamageSelfMitigated { get; set; }

        /// <summary>
        /// Magical Damage Taken.
        /// </summary>
        [JsonProperty("magicalDamageTaken")]
        public long MagicalDamageTaken { get; set; }

        /// <summary>
        /// First Inhibitor Assist.
        /// </summary>
        [JsonProperty("firstInhibitorAssist	")]
        public bool FirstInhibitorAssist { get; set; }

        /// <summary>
        /// First Inhibitor Kill.
        /// </summary>
        [JsonProperty("firstInhibitorKill")]
        public bool FirstInhibitorKill { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk0Var2")]
        public int Perk0Var2 { get; set; }

        /// <summary>
        /// True Damage Taken.
        /// </summary>
        [JsonProperty("trueDamageTaken")]
        public long TrueDamageTaken { get; set; }

        /// <summary>
        /// Assists.	
        /// </summary>
        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("perk4Var2")]
        public int Perk4Var2 { get; set; }

        /// <summary>
        /// Gold Spent.
        /// </summary>
        [JsonProperty("goldSpent")]
        public int GoldSpent { get; set; }

        /// <summary>
        /// True Damage Dealt.
        /// </summary>
        [JsonProperty("trueDamageDealt")]
        public long TrueDamageDealt { get; set; }

        /// <summary>
        /// Participant Id.
        /// </summary>
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        /// <summary>
        /// Physical Damage Dealt.
        /// </summary>
        [JsonProperty("physicalDamageDealt")]
        public long PhysicalDamageDealt { get; set; }

        /// <summary>
        /// Sight Wards Bought In Game.
        /// </summary>
        [JsonProperty("sightWardsBoughtInGame")]
        public int SightWardsBoughtInGame { get; set; }

        /// <summary>
        /// Total Damage Dealt To Champions.
        /// </summary>
        [JsonProperty("totalDamageDealtToChampions")]
        public long TotalDamageDealtToChampions { get; set; }

        /// <summary>
        /// Physical Damage Taken.
        /// </summary>
        [JsonProperty("physicalDamageTaken")]
        public long PhysicalDamageTaken { get; set; }

        /// <summary>
        /// Total Player Score.
        /// </summary>
        [JsonProperty("totalPlayerScore")]
        public int TotalPlayerScore { get; set; }

        /// <summary>
        /// Win.
        /// </summary>
        [JsonProperty("win")]
        public bool Win { get; set; }

        /// <summary>
        /// Objective Player Score.
        /// </summary>
        [JsonProperty("objectivePlayerScore")]
        public int ObjectivePlayerScore { get; set; }

        /// <summary>
        /// Total Damage Dealt.
        /// </summary>
        [JsonProperty("totalDamageDealt")]
        public long TotalDamageDealt { get; set; }

        /// <summary>
        /// Neutral Minions Killed Enemy Jungle.
        /// </summary>
        [JsonProperty("neutralMinionsKilledEnemyJungle")]
        public int NeutralMinionsKilledEnemyJungle { get; set; }

        /// <summary>
        /// Deaths.
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        /// <summary>
        /// Wards Placed.
        /// </summary>
        [JsonProperty("wardsPlaced")]
        public int WardsPlaced { get; set; }
        
        /// <summary>
        /// Primary rune path.
        /// </summary>
        [JsonProperty("perkPrimaryStyle")]
        public int PerkPrimaryStyle { get; set; }

        /// <summary>
        /// Secondary rune path.
        /// </summary>
        [JsonProperty("perkSubStyle")]
        public int PerkSubStyle { get; set; }

        /// <summary>
        /// Turret Kills.
        /// </summary>
        [JsonProperty("turretKills")]
        public int TurretKills { get; set; }

        /// <summary>
        /// True Damage Dealt To Champions.
        /// </summary>
        [JsonProperty("trueDamageDealtToChampions")]
        public long TrueDamageDealtToChampions { get; set; }

        /// <summary>
        /// Gold Earned.
        /// </summary>
        [JsonProperty("goldEarned")]
        public int GoldEarned { get; set; }

        /// <summary>
        /// killing Sprees.
        /// </summary>
        [JsonProperty("killingSprees")]
        public int KillingSprees { get; set; }

        /// <summary>
        /// Unreal Kills.
        /// </summary>
        [JsonProperty("unrealKills")]
        public int UnrealKills { get; set; }

        /// <summary>
        /// Champion Level.
        /// </summary>
        [JsonProperty("champLevel")]
        public int ChampLevel { get; set; }

        /// <summary>
        /// Double Kills.
        /// </summary>
        [JsonProperty("doubleKills")]
        public int DoubleKills { get; set; }

        /// <summary>
        /// Inhibitor Kills.
        /// </summary>
        [JsonProperty("inhibitorKills")]
        public int InhibitorKills { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk0Var1")]
        public int Perk0Var1 { get; set; }
        
        /// <summary>
        /// Combat Player Score.
        /// </summary>
        [JsonProperty("combatPlayerScore")]
        public int CombatPlayerScore { get; set; }

        /// <summary>
        /// Post game rune stats.
        /// </summary>
        [JsonProperty("perk0Var3")]
        public int Perk0Var3 { get; set; }

        /// <summary>
        /// vision Wards Bought In Game.	
        /// </summary>
        [JsonProperty("visionWardsBoughtInGame")]
        public int VisionWardsBoughtInGame { get; set; }

        /// <summary>
        /// PentaKills.
        /// </summary>
        [JsonProperty("pentaKills")]
        public int PentaKills { get; set; }

        /// <summary>
        /// Total Heal.
        /// </summary>
        [JsonProperty("totalHeal")]
        public long TotalHeal { get; set; }

        /// <summary>
        /// Total Minions Killed.
        /// </summary>
        [JsonProperty("totalMinionsKilled")]
        public int TotalMinionsKilled { get; set; }

        /// <summary>
        /// Time Crowd Controlling Others.
        /// </summary>
        [JsonProperty("timeCCingOthers")]
        public long TimeCCingOthers { get; set; }

        /// <summary>
        /// First Tower Kill.
        /// </summary>
        [JsonProperty("firstTowerKill")]
        public bool FirstTowerKill { get; set; }

        /// <summary>
        /// First Tower Assist.
        /// </summary>
        [JsonProperty("firstTowerAssist")]
        public bool FirstTowerAssist { get; set; }

        /// <summary>
        /// Altars Neutralized.
        /// </summary>
        [JsonProperty("altarsNeutralized")]
        public int AltarsNeutralized { get; set; }

        /// <summary>
        /// Altars Captured.
        /// </summary>
        [JsonProperty("altarsCaptured")]
        public int AltarsCaptured { get; set; }
    }
}
