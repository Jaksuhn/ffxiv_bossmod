﻿namespace BossMod.RPR;

public enum AID : uint
{
    None = 0,
    Sprint = ClassShared.AID.Sprint,

    TheEnd = 24858, // LB3, 4.5s cast, range 8, single-target, targets=hostile, animLock=???, castAnimLock=3.700
    Slice = 24373, // L1, instant, GCD, range 3, single-target, targets=hostile
    WaxingSlice = 24374, // L5, instant, GCD, range 3, single-target, targets=hostile
    ShadowofDeath = 24378, // L10, instant, GCD, range 3, single-target, targets=hostile
    Harpe = 24386, // L15, 1.3s cast, GCD, range 25, single-target, targets=hostile
    HellsIngress = 24401, // L20, instant, 20.0s CD (group 3), range 0, single-target, targets=self, animLock=0.800
    HellsEgress = 24402, // L20, instant, 20.0s CD (group 3), range 0, single-target, targets=self, animLock=0.800
    SpinningScythe = 24376, // L25, instant, GCD, range 0, AOE 5 circle, targets=self
    InfernalSlice = 24375, // L30, instant, GCD, range 3, single-target, targets=hostile
    WhorlofDeath = 24379, // L35, instant, GCD, range 0, AOE 5 circle, targets=self
    ArcaneCrest = 24404, // L40, instant, 30.0s CD (group 5), range 0, single-target, targets=self
    NightmareScythe = 24377, // L45, instant, GCD, range 0, AOE 5 circle, targets=self
    BloodStalk = 24389, // L50, instant, 1.0s CD (group 0), range 3, single-target, targets=hostile
    GrimSwathe = 24392, // L55, instant, 1.0s CD (group 0), range 8, AOE 8+R ?-degree cone, targets=hostile
    SoulSlice = 24380, // L60, instant, 30.0s CD (group 4/57), range 3, single-target, targets=hostile
    SoulScythe = 24381, // L65, instant, 30.0s CD (group 4/57), range 0, AOE 5 circle, targets=self
    UnveiledGibbet = 24390, // L70, instant, 1.0s CD (group 0), range 3, single-target, targets=hostile
    Gibbet = 24382, // L70, instant, GCD, range 3, single-target, targets=hostile
    UnveiledGallows = 24391, // L70, instant, 1.0s CD (group 0), range 3, single-target, targets=hostile
    Gallows = 24383, // L70, instant, GCD, range 3, single-target, targets=hostile
    Guillotine = 24384, // L70, instant, GCD, range 8, AOE 8+R ?-degree cone, targets=hostile
    ArcaneCircle = 24405, // L72, instant, 120.0s CD (group 14), range 0, AOE 30 circle, targets=self
    Regress = 24403, // L74, instant, 10.0s CD (group 1), range 30, ???, targets=area, animLock=0.800
    Gluttony = 24393, // L76, instant, 60.0s CD (group 9), range 25, AOE 5 circle, targets=hostile
    Enshroud = 24394, // L80, instant, 15.0s CD (group 2), range 0, single-target, targets=self
    VoidReaping = 24395, // L80, instant, GCD, range 3, single-target, targets=hostile
    CrossReaping = 24396, // L80, instant, GCD, range 3, single-target, targets=hostile
    GrimReaping = 24397, // L80, instant, GCD, range 8, AOE 8+R ?-degree cone, targets=hostile
    HarvestMoon = 24388, // L82, instant, GCD, range 25, AOE 5 circle, targets=hostile
    SoulSow = 24387, // L82, 5.0s cast, GCD, range 0, single-target, targets=self
    LemuresSlice = 24399, // L86, instant, 1.0s CD (group 0), range 3, single-target, targets=hostile
    LemuresScythe = 24400, // L86, instant, 1.0s CD (group 0), range 8, AOE 8+R ?-degree cone, targets=hostile
    PlentifulHarvest = 24385, // L88, instant, GCD, range 15, AOE 15+R width 4 rect, targets=hostile
    Communio = 24398, // L90, 1.3s cast, GCD, range 25, AOE 5 circle, targets=hostile, animLock=???

    // Shared
    Braver = ClassShared.AID.Braver, // LB1, 2.0s cast, range 8, single-target, targets=hostile, castAnimLock=3.860
    Bladedance = ClassShared.AID.Bladedance, // LB2, 3.0s cast, range 8, single-target, targets=hostile, castAnimLock=3.860
    SecondWind = ClassShared.AID.SecondWind, // L8, instant, 120.0s CD (group 49), range 0, single-target, targets=self
    LegSweep = ClassShared.AID.LegSweep, // L10, instant, 40.0s CD (group 41), range 3, single-target, targets=hostile
    Bloodbath = ClassShared.AID.Bloodbath, // L12, instant, 90.0s CD (group 46), range 0, single-target, targets=self
    Feint = ClassShared.AID.Feint, // L22, instant, 90.0s CD (group 47), range 10, single-target, targets=hostile
    ArmsLength = ClassShared.AID.ArmsLength, // L32, instant, 120.0s CD (group 48), range 0, single-target, targets=self
    TrueNorth = ClassShared.AID.TrueNorth, // L50, instant, 45.0s CD (group 45/50) (2 charges), range 0, single-target, targets=self
}

public enum TraitID : uint
{
    None = 0,
    SoulGauge = 379, // L50
    DeathScytheMastery1 = 380, // L60
    EnhancedAvatar = 381, // L70
    Hellsgate = 382, // L74
    TemperedSoul = 383, // L78
    ShroudGauge = 384, // L80
    EnhancedArcaneCrest = 385, // L84
    DeathScytheMastery2 = 523, // L84
    EnhancedShroud = 386, // L86
    EnhancedArcaneCircle = 387, // L88
}

public sealed class Definitions : IDisposable
{
    public static readonly uint[] UnlockQuests = [69614];

    public static bool Unlocked(AID id, int level, int questProgress) => id switch
    {
        AID.WaxingSlice => level >= 5,
        AID.SecondWind => level >= 8,
        AID.LegSweep => level >= 10,
        AID.ShadowofDeath => level >= 10,
        AID.Bloodbath => level >= 12,
        AID.Harpe => level >= 15,
        AID.HellsIngress => level >= 20,
        AID.HellsEgress => level >= 20,
        AID.Feint => level >= 22,
        AID.SpinningScythe => level >= 25,
        AID.InfernalSlice => level >= 30,
        AID.ArmsLength => level >= 32,
        AID.WhorlofDeath => level >= 35,
        AID.ArcaneCrest => level >= 40,
        AID.NightmareScythe => level >= 45,
        AID.BloodStalk => level >= 50,
        AID.TrueNorth => level >= 50,
        AID.GrimSwathe => level >= 55,
        AID.SoulSlice => level >= 60,
        AID.SoulScythe => level >= 65,
        AID.UnveiledGibbet => level >= 70,
        AID.Gibbet => level >= 70,
        AID.UnveiledGallows => level >= 70,
        AID.Gallows => level >= 70,
        AID.Guillotine => level >= 70,
        AID.ArcaneCircle => level >= 72,
        AID.Regress => level >= 74,
        AID.Gluttony => level >= 76,
        AID.Enshroud => level >= 80 && questProgress > 0,
        AID.VoidReaping => level >= 80 && questProgress > 0,
        AID.CrossReaping => level >= 80 && questProgress > 0,
        AID.GrimReaping => level >= 80 && questProgress > 0,
        AID.HarvestMoon => level >= 82,
        AID.SoulSow => level >= 82,
        AID.LemuresSlice => level >= 86,
        AID.LemuresScythe => level >= 86,
        AID.PlentifulHarvest => level >= 88,
        AID.Communio => level >= 90,
        _ => true
    };

    public static bool Unlocked(TraitID id, int level, int questProgress) => id switch
    {
        TraitID.SoulGauge => level >= 50,
        TraitID.DeathScytheMastery1 => level >= 60,
        TraitID.EnhancedAvatar => level >= 70,
        TraitID.Hellsgate => level >= 74,
        TraitID.TemperedSoul => level >= 78,
        TraitID.ShroudGauge => level >= 80 && questProgress > 0,
        TraitID.EnhancedArcaneCrest => level >= 84,
        TraitID.DeathScytheMastery2 => level >= 84,
        TraitID.EnhancedShroud => level >= 86,
        TraitID.EnhancedArcaneCircle => level >= 88,
        _ => true
    };

    public Definitions(ActionDefinitions d)
    {
        d.RegisterSpell(AID.TheEnd, castAnimLock: 3.70f); // animLock=???, castAnimLock=3.700
        d.RegisterSpell(AID.Slice);
        d.RegisterSpell(AID.WaxingSlice);
        d.RegisterSpell(AID.ShadowofDeath);
        d.RegisterSpell(AID.Harpe);
        d.RegisterSpell(AID.HellsIngress, instantAnimLock: 0.80f); // animLock=0.800
        d.RegisterSpell(AID.HellsEgress, instantAnimLock: 0.80f); // animLock=0.800
        d.RegisterSpell(AID.SpinningScythe);
        d.RegisterSpell(AID.InfernalSlice);
        d.RegisterSpell(AID.WhorlofDeath);
        d.RegisterSpell(AID.ArcaneCrest);
        d.RegisterSpell(AID.NightmareScythe);
        d.RegisterSpell(AID.BloodStalk);
        d.RegisterSpell(AID.GrimSwathe);
        d.RegisterSpell(AID.SoulSlice, maxCharges: 2);
        d.RegisterSpell(AID.SoulScythe, maxCharges: 2);
        d.RegisterSpell(AID.UnveiledGibbet);
        d.RegisterSpell(AID.Gibbet);
        d.RegisterSpell(AID.UnveiledGallows);
        d.RegisterSpell(AID.Gallows);
        d.RegisterSpell(AID.Guillotine);
        d.RegisterSpell(AID.ArcaneCircle);
        d.RegisterSpell(AID.Regress, instantAnimLock: 0.80f); // animLock=0.800
        d.RegisterSpell(AID.Gluttony);
        d.RegisterSpell(AID.Enshroud);
        d.RegisterSpell(AID.VoidReaping);
        d.RegisterSpell(AID.CrossReaping);
        d.RegisterSpell(AID.GrimReaping);
        d.RegisterSpell(AID.HarvestMoon);
        d.RegisterSpell(AID.SoulSow);
        d.RegisterSpell(AID.LemuresSlice);
        d.RegisterSpell(AID.LemuresScythe);
        d.RegisterSpell(AID.PlentifulHarvest);
        d.RegisterSpell(AID.Communio); // animLock=???

        Customize(d);
    }

    public void Dispose() { }

    private void Customize(ActionDefinitions d)
    {
        d.Spell(AID.ArcaneCrest)!.EffectDuration = 5;
        d.Spell(AID.ArcaneCircle)!.EffectDuration = 20;
    }
}