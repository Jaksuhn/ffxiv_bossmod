using System.Collections.Generic;

namespace BossMod.MCH;
public enum AID : uint
{
    None = 0,

    // GCDs
    SplitShot = 2866, // L1, instant, range 25, single-target 0/0, targets=hostile, animLock=???
    SlugShot = 2868, // L2, instant, range 25, single-target 0/0, targets=hostile, animLock=???
    SpreadShot = 2870, // L18, instant, range 12, AOE cone 12/0, targets=hostile, animLock=???
    CleanShot = 2873, // L26, instant, range 25, single-target 0/0, targets=hostile, animLock=???
    HeatBlast = 7410, // L35, instant, range 25, single-target 0/0, targets=hostile, animLock=0.600s
    AutoCrossbow = 16497, // L52, instant, range 12, AOE cone 12/0, targets=hostile, animLock=???
    HeatedSplitShot = 7411, // L54, instant, range 25, single-target 0/0, targets=hostile, animLock=0.600s
    HeatedSlugShot = 7412, // L60, instant, range 25, single-target 0/0, targets=hostile, animLock=???
    HeatedCleanShot = 7413, // L64, instant, range 25, single-target 0/0, targets=hostile, animLock=???
    ArmPunch = 16504, // L80, instant, range 3, single-target 0/0, targets=hostile, animLock=???
    RollerDash = 17206, // L80, instant, range 30, single-target 0/0, targets=hostile, animLock=???
    Scattergun = 25786, // L82, instant, range 12, AOE cone 12/0, targets=hostile, animLock=0.600s

    // oGCDs
    HotShot = 2872, // L4, instant, 40.0s CD (group 7), range 25, single-target 0/0, targets=hostile, animLock=???
    LegGraze = 7554, // L6, instant, 30.0s CD (group 42), range 25, single-target 0/0, targets=hostile, animLock=???
    SecondWind = 7541, // L8, instant, 120.0s CD (group 49), range 0, single-target 0/0, targets=self, animLock=???
    Reassemble = 2876, // L10, instant, 55.0s CD (group 21), range 0, single-target 0/0, targets=self, animLock=0.600s
    FootGraze = 7553, // L10, instant, 30.0s CD (group 41), range 25, single-target 0/0, targets=hostile, animLock=???
    GaussRound = 2874, // L15, instant, 30.0s CD (group 9) (2 charges), range 25, single-target 0/0, targets=hostile, animLock=0.600s
    Peloton = 7557, // L20, instant, 5.0s CD (group 40), range 0, AOE circle 30/0, targets=self, animLock=???
    HeadGraze = 7551, // L24, instant, 30.0s CD (group 43), range 25, single-target 0/0, targets=hostile, animLock=???
    Hypercharge = 17209, // L30, instant, 10.0s CD (group 4), range 0, single-target 0/0, targets=self, animLock=0.600s
    ArmsLength = 7548, // L32, instant, 120.0s CD (group 48), range 0, single-target 0/0, targets=self, animLock=???
    RookOverload = 7416, // L40, instant, 0.0s CD (group -1), range 40, single-target 0/0, targets=hostile, animLock=???
    RookAutoturret = 2864, // L40, instant, 6.0s CD (group 3), range 0, single-target 0/0, targets=self, animLock=???
    RookOverdrive = 7415, // L40, instant, 15.0s CD (group 3), range 25, single-target 0/0, targets=self, animLock=???
    Wildfire = 2878, // L45, instant, 120.0s CD (group 19), range 25, single-target 0/0, targets=hostile, animLock=0.600s
    Detonator = 16766, // L45, instant, 1.0s CD (group 0), range 25, single-target 0/0, targets=self, animLock=???
    Ricochet = 2890, // L50, instant, 30.0s CD (group 10) (2 charges), range 25, AOE circle 5/0, targets=hostile, animLock=0.600s
    Tactician = 16889, // L56, instant, 120.0s CD (group 23), range 0, AOE circle 30/0, targets=self, animLock=???
    Drill = 16498, // L58, instant, 20.0s CD (group 6), range 25, single-target 0/0, targets=hostile, animLock=0.600s
    Dismantle = 2887, // L62, instant, 120.0s CD (group 18), range 25, single-target 0/0, targets=hostile, animLock=???
    BarrelStabilizer = 7414, // L66, instant, 120.0s CD (group 20), range 0, single-target 0/0, targets=self, animLock=0.600s
    Flamethrower = 7418, // L70, instant, 60.0s CD (group 12), range 0, single-target 8/0, targets=self, animLock=???
    Bioblaster = 16499, // L72, instant, 20.0s CD (group 6), range 12, AOE cone 12/0, targets=hostile, animLock=???
    AirAnchor = 16500, // L76, instant, 40.0s CD (group 8), range 25, single-target 0/0, targets=hostile, animLock=0.600s
    QueenOverdrive = 16502, // L80, instant, 15.0s CD (group 1), range 30, single-target 0/0, targets=self, animLock=???
    AutomatonQueen = 16501, // L80, instant, 6.0s CD (group 1), range 0, single-target 0/0, targets=self, animLock=???
    PileBunker = 16503, // L80, instant, 0.0s CD (group -1), range 3, single-target 0/0, targets=hostile, animLock=???
    CrownedCollider = 25787, // L86, instant, 0.0s CD (group -1), range 3, single-target 0/0, targets=hostile, animLock=???
    ChainSaw = 25788, // L90, instant, 60.0s CD (group 11), range 25, AOE rect 25/4, targets=hostile, animLock=0.600s

    PVP_BlastCharge = 29402,
    PVP_Scattergun = 29404,
    PVP_Drill = 29405,
    PVP_Wildfire = 29409,
    PVP_BishopAutoturret = 29412,
    PVP_Analysis = 29414,
    PVP_MarksmansSpite = 29415,
    PVP_HeatBlast = 29403,
    PVP_Bioblaster = 29406,
    PVP_AirAnchor = 29407,
    PVP_ChainSaw = 29408,
    PVP_AetherMortar = 29413,
    PVP_StandardIssueElixir = 29055,
    PVP_Recuperate = 29711,
    PVP_Purify = 29056,
    PVP_Guard = 29054,
}

public enum TraitID : uint
{
    None = 0,
    IncreasedActionDamage = 117, // L20
    IncreasedActionDamageII = 119, // L40
    SplitShotMastery = 288, // L54
    SlugShotMastery = 289, // L60
    CleanShotMastery = 290, // L64
    ChargedActionMastery = 292, // L74
    HotShotMastery = 291, // L76
    EnhancedWildfire = 293, // L78
    Promotion = 294, // L80
    SpreadShotMastery = 449, // L82
    EnhancedReassemble = 450, // L84
    MarksmansMastery = 517, // L84
    QueensGambit = 451, // L86
    EnhancedTactician = 452, // L88
}

public enum CDGroup : int
{
    Detonator = 0, // 1.0 max
    QueenOverdrive = 1, // variable max, shared by Queen Overdrive, Automaton Queen
    PVP_Wildfire = 2,
    RookAutoturret = 3, // variable max, shared by Rook Autoturret, Rook Overdrive
    Hypercharge = 4, // 10.0 max
    Drill = 6, // 20.0 max, shared by Drill, Bioblaster
    HotShot = 7, // 40.0 max
    AirAnchor = 8, // 40.0 max
    GaussRound = 9, // 2*30.0 max
    Ricochet = 10, // 2*30.0 max
    ChainSaw = 11, // 60.0 max
    Flamethrower = 12, // 60.0 max
    Dismantle = 18, // 120.0 max
    Wildfire = 19, // 120.0 max
    BarrelStabilizer = 20, // 120.0 max
    Reassemble = 21, // 55.0 max
    Tactician = 23, // 120.0 max
    Peloton = 40, // 5.0 max
    FootGraze = 41, // 30.0 max
    LegGraze = 42, // 30.0 max
    HeadGraze = 43, // 30.0 max
    ArmsLength = 48, // 120.0 max
    SecondWind = 49, // 120.0 max
    PVP_AetherMortar = 76,
    PVP_StandardIssueElixir = 57,
    PVP_Recuperate = 26,
    PVP_Purify = 25,
    PVP_Guard = 27,
}

public enum SID : uint
{
    None = 0,
    Reassembled = 851, // applied by Reassemble to self
    Dismantled = 860,
    WildfireTarget = 861, // applied by Wildfire to target
    Flamethrower = 1205,
    Bioblaster = 1866,
    //Wildfire = 1946, // applied by Wildfire to self
    Tactician = 1951,
    Overheated = 2688, // applied by Hypercharge to self
    Sprint = 50, // applied by Sprint to self
    Peloton = 1199,

    PVP_WildfireTarget = 1323,
    PVP_Heat = 3148, // max 15s, stacks 5 times
    PVP_Overheated = 3149, // gained after 5 stacks of Heat
    PVP_DrillPrimed = 3150,
    PVP_BioblasterPrimed = 3151,
    PVP_AirAnchorPrimed = 3152,
    PVP_ChainsawPrimed = 3153,
}

public static class Definitions
{
    public static uint[] UnlockQuests = { 66094, 66103, 66597, 66598, 66599, 66600, 66602, 67563, 67564, 67567, 67966 };

    public static bool Unlocked(AID aid, int level, int questProgress)
    {
        return aid switch
        {
            AID.SlugShot => level >= 2,
            AID.HotShot => level >= 4,
            AID.LegGraze => level >= 6,
            AID.SecondWind => level >= 8,
            AID.Reassemble => level >= 10,
            AID.FootGraze => level >= 10,
            AID.GaussRound => level >= 15,
            AID.SpreadShot => level >= 18,
            AID.Peloton => level >= 20,
            AID.HeadGraze => level >= 24,
            AID.CleanShot => level >= 26,
            AID.Hypercharge => level >= 30 && questProgress > 0,
            AID.ArmsLength => level >= 32,
            AID.HeatBlast => level >= 35 && questProgress > 1,
            AID.RookOverload => level >= 40,
            AID.RookAutoturret => level >= 40 && questProgress > 2,
            AID.RookOverdrive => level >= 40,
            AID.Wildfire => level >= 45,
            AID.Detonator => level >= 45,
            AID.Ricochet => level >= 50 && questProgress > 3,
            AID.AutoCrossbow => level >= 52 && questProgress > 4,
            AID.HeatedSplitShot => level >= 54 && questProgress > 5,
            AID.Tactician => level >= 56 && questProgress > 6,
            AID.Drill => level >= 58 && questProgress > 7,
            AID.HeatedSlugShot => level >= 60 && questProgress > 8,
            AID.Dismantle => level >= 62,
            AID.HeatedCleanShot => level >= 64,
            AID.BarrelStabilizer => level >= 66,
            AID.Flamethrower => level >= 70 && questProgress > 9,
            AID.Bioblaster => level >= 72,
            AID.AirAnchor => level >= 76,
            AID.ArmPunch => level >= 80,
            AID.QueenOverdrive => level >= 80,
            AID.AutomatonQueen => level >= 80,
            AID.RollerDash => level >= 80,
            AID.PileBunker => level >= 80,
            AID.Scattergun => level >= 82,
            AID.CrownedCollider => level >= 86,
            AID.ChainSaw => level >= 90,
            _ => true,
        };
    }

    public static bool Unlocked(TraitID tid, int level, int questProgress)
    {
        return tid switch
        {
            TraitID.IncreasedActionDamage => level >= 20,
            TraitID.IncreasedActionDamageII => level >= 40,
            TraitID.SplitShotMastery => level >= 54 && questProgress > 5,
            TraitID.SlugShotMastery => level >= 60 && questProgress > 8,
            TraitID.CleanShotMastery => level >= 64,
            TraitID.ChargedActionMastery => level >= 74,
            TraitID.HotShotMastery => level >= 76,
            TraitID.EnhancedWildfire => level >= 78,
            TraitID.Promotion => level >= 80,
            TraitID.SpreadShotMastery => level >= 82,
            TraitID.EnhancedReassemble => level >= 84,
            TraitID.MarksmansMastery => level >= 84,
            TraitID.QueensGambit => level >= 86,
            TraitID.EnhancedTactician => level >= 88,
            _ => true,
        };
    }

    public static Dictionary<ActionID, ActionDefinition> SupportedActions;
    static Definitions()
    {
        SupportedActions = CommonDefinitions.CommonActionData(CommonDefinitions.IDPotionStr);
        // PVE
        SupportedActions.GCD(AID.HeadGraze, 25);
        SupportedActions.GCD(AID.LegGraze, 25);
        SupportedActions.GCD(AID.FootGraze, 25);
        SupportedActions.GCD(AID.SecondWind, 25);
        SupportedActions.GCD(AID.ArmsLength, 25);
        SupportedActions.GCD(AID.Peloton, 25);

        SupportedActions.GCD(AID.SplitShot, 25);
        SupportedActions.GCD(AID.SlugShot, 25);
        SupportedActions.GCD(AID.SpreadShot, 12);
        SupportedActions.GCD(AID.CleanShot, 25);
        SupportedActions.GCD(AID.HeatBlast, 25);
        SupportedActions.GCD(AID.AutoCrossbow, 12);
        SupportedActions.GCD(AID.HeatedSplitShot, 25);
        SupportedActions.GCD(AID.HeatedSlugShot, 25);
        SupportedActions.GCD(AID.HeatedCleanShot, 25);
        SupportedActions.GCD(AID.ArmPunch, 3);
        SupportedActions.GCD(AID.RollerDash, 30);
        SupportedActions.GCD(AID.Scattergun, 12);

        SupportedActions.GCD(AID.HotShot, 25);
        SupportedActions.OGCD(AID.Reassemble, 0, CDGroup.Reassemble, 55);
        SupportedActions.OGCD(AID.GaussRound, 25, CDGroup.GaussRound, 30);
        SupportedActions.OGCD(AID.Hypercharge, 0, CDGroup.Hypercharge, 10);
        SupportedActions.OGCD(AID.RookOverload, 40, CDGroup.Detonator, 0);
        SupportedActions.OGCD(AID.RookAutoturret, 0, CDGroup.RookAutoturret, 6);
        SupportedActions.OGCD(AID.RookOverdrive, 25, CDGroup.RookAutoturret, 15);
        SupportedActions.OGCD(AID.Wildfire, 25, CDGroup.Wildfire, 120);
        SupportedActions.OGCD(AID.Detonator, 25, CDGroup.Detonator, 1);
        SupportedActions.OGCD(AID.Ricochet, 25, CDGroup.Ricochet, 30);
        SupportedActions.OGCD(AID.Tactician, 0, CDGroup.Tactician, 90);
        SupportedActions.GCDWithCooldown(AID.Drill, 25, CDGroup.Drill, 20);
        SupportedActions.OGCD(AID.Dismantle, 25, CDGroup.Dismantle, 120);
        SupportedActions.OGCD(AID.BarrelStabilizer, 0, CDGroup.BarrelStabilizer, 120);
        SupportedActions.OGCD(AID.Flamethrower, 8, CDGroup.Flamethrower, 60);
        SupportedActions.GCDWithCooldown(AID.Bioblaster, 12, CDGroup.Drill, 20);
        SupportedActions.GCDWithCooldown(AID.AirAnchor, 25, CDGroup.AirAnchor, 20);
        SupportedActions.OGCD(AID.QueenOverdrive, 30, CDGroup.QueenOverdrive, 15);
        SupportedActions.OGCD(AID.AutomatonQueen, 0, CDGroup.QueenOverdrive, 6);
        SupportedActions.OGCD(AID.PileBunker, 3, CDGroup.Detonator, 0);
        SupportedActions.OGCD(AID.CrownedCollider, 3, CDGroup.Detonator, 0);
        SupportedActions.GCDWithCooldown(AID.ChainSaw, 25, CDGroup.ChainSaw, 90);

        // PVP
        SupportedActions.GCD(AID.PVP_BlastCharge, 25);
        SupportedActions.GCDWithCooldown(AID.PVP_Scattergun, 12, CDGroup.QueenOverdrive, 20);
        SupportedActions.GCDWithCharges(AID.PVP_Drill, 25, CDGroup.QueenOverdrive, 10, 2);
        SupportedActions.OGCD(AID.PVP_Wildfire, 25, CDGroup.PVP_Wildfire, 20);
        SupportedActions.OGCD(AID.PVP_BishopAutoturret, 25, CDGroup.RookAutoturret, 30);
        SupportedActions.OGCD(AID.PVP_Analysis, 0, CDGroup.Hypercharge, 20);
        SupportedActions.GCD(AID.PVP_MarksmansSpite, 50); // ?
        SupportedActions.GCD(AID.PVP_HeatBlast, 25);
        SupportedActions.GCDWithCharges(AID.PVP_Bioblaster, 12, CDGroup.QueenOverdrive, 10, 2);
        SupportedActions.GCDWithCharges(AID.PVP_AirAnchor, 25, CDGroup.QueenOverdrive, 10, 2);
        SupportedActions.GCDWithCharges(AID.PVP_ChainSaw, 25, CDGroup.QueenOverdrive, 10, 2);
        SupportedActions.OGCD(AID.PVP_AetherMortar, 0, CDGroup.PVP_AetherMortar, 1);
        SupportedActions.OGCD(AID.PVP_StandardIssueElixir, 0, CDGroup.PVP_StandardIssueElixir, 5);
        SupportedActions.OGCD(AID.PVP_Recuperate, 0, CDGroup.PVP_Recuperate, 1);
        SupportedActions.OGCD(AID.PVP_Purify, 0, CDGroup.PVP_Purify, 30);
        SupportedActions.OGCD(AID.PVP_Guard, 0, CDGroup.PVP_Guard, 30);
    }
}