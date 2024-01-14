using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.FFXIV.Client.Game.UI;
using System.Collections.Generic;
using System.Linq;

namespace BossMod.BLU
{
    public enum AID : uint
    {
        None = 0,
        Sprint = 3,

        Snort = 11383,
        FourTonzeWeight = 11384,
        WaterCannon = 11385,
        SongOfTorment = 11386,
        HighVoltage = 11387,
        BadBreath = 11388,
        FlyingFrenzy = 11389,
        AquaBreath = 11390,
        Plaincracker = 11391,
        AcornBomb = 11392,
        Bristle = 11393,
        MindBlast = 11394,
        BloodDrain = 11395,
        BombToss = 11396,
        ThousandNeedles = 11397,
        DrillCannons = 11398,
        TheLook = 11399,
        SharpenedKnife = 11400,
        Loom = 11401,
        FlameThrower = 11402,
        Faze = 11403,
        Glower = 11404,
        Missile = 11405,
        WhiteWind = 11406,
        FinalSting = 11407,
        SelfDestruct = 11408,
        Transfusion = 11409,
        ToadOil = 11410,
        OffGuard = 11411,
        StickyTongue = 11412,
        TailScrew = 11413,
        LevelFivePetrify = 11414,
        MoonFlute = 11415,
        Doom = 11416,
        MightyGuard = 11417,
        IceSpikes = 11418,
        TheRamsVoice = 11419,
        TheDragonsVoice = 11420,
        PeculiarLight = 11421,
        InkJet = 11422,
        FlyingSardine = 11423,
        Diamondback = 11424,
        FireAngon = 11425,
        FeatherRain = 11426,
        Eruption = 11427,
        MountainBuster = 11428,
        ShockStrike = 11429,
        GlassDance = 11430,
        VeilOfTheWhorl = 11431,
        AlpineDraft = 18295,
        ProteanWave = 18296,
        Northerlies = 18297,
        Electrogenesis = 18298,
        Kaltstrahl = 18299,
        AbyssalTransfixion = 18300,
        Chirp = 18301,
        EerieSoundwave = 18302,
        PomCure = 18303,
        Gobskin = 18304,
        MagicHammer = 18305,
        Avail = 18306,
        FrogLegs = 18307,
        SonicBoom = 18308,
        Whistle = 18309,
        WhiteKnightsTour = 18310,
        BlackKnightsTour = 18311,
        LevelFiveDeath = 18312,
        Launcher = 18313,
        PerpetualRay = 18314,
        Cactguard = 18315,
        RevengeBlast = 18316,
        AngelWhisper = 18317,
        Exuviation = 18318,
        Reflux = 18319,
        Devour = 18320,
        CondensedLibra = 18321,
        AethericMimicry = 18322,
        Surpanakha = 18323,
        Quasar = 18324,
        JKick = 18325,
        TripleTrident = 23264,
        Tingle = 23265,
        TatamiGaeshi = 23266,
        ColdFog = 23267,
        WhiteDeath = 23268,
        Stotram = 23269,
        SaintlyBeam = 23270,
        FeculentFlood = 23271,
        AngelsSnack = 23272,
        ChelonianGate = 23273,
        DivineCataract = 23274,
        TheRoseOfDestruction = 23275,
        BasicInstinct = 23276,
        Ultravibration = 23277,
        Blaze = 23278,
        MustardBomb = 23279,
        DragonForce = 23280,
        AetherialSpark = 23281,
        HydroPull = 23282,
        MaledictionOfWater = 23283,
        ChocoMeteor = 23284,
        MatraMagic = 23285,
        PeripheralSynthesis = 23286,
        BothEnds = 23287,
        PhantomFlurry = 23288,
        Nightbloom = 23290,
        GoblinPunch = 34563,
        RightRound = 34564,
        Schiltron = 34565,
        Rehydration = 34566,
        BreathOfMagic = 34567,
        WildRage = 34568,
        PeatPelt = 34569,
        DeepClean = 34570,
        RubyDynamics = 34571,
        DivinationRune = 34572,
        DimensionalShift = 34573,
        ConvictionMarcato = 34574,
        ForceField = 34575,
        WingedReprobation = 34576,
        LaserEye = 34577,
        CandyCane = 34578,
        MortalFlame = 34579,
        SeaShanty = 34580,
        Apokalypsis = 34581,
        BeingMortal = 34582,

        // offsensive CDs
        Swiftcast = 7561, // L18, instant, 60.0s CD (group 42), range 0, single-target 0/0, targets=self
        LucidDreaming = 7562, // L14, instant, 60.0s CD (group 41), range 0, single-target 0/0, targets=self

        // defensive CDs
        Addle = 7560, // L8, instant, 90.0s CD (group 40), range 25, single-target 0/0, targets=hostile
        Surecast = 7559, // L44, instant, 120.0s CD (group 43), range 0, single-target 0/0, targets=self

        // misc
        Sleep = 25880, // L10, 2.5s cast, range 30, AOE circle 5/0, targets=hostile
    }

    public enum TraitID : uint
    {
        None = 0,
        Learning = 219, // L1, allows learning spells
        MaimAndMend1 = 220, // L10, damage/healing increase
        MaimAndMend2 = 221, // L20, damage/healing increase
        MaimAndMend3 = 222, // L30, damage/healing increase
        MaimAndMend4 = 223, // L40, damage/healing increase
        MaimAndMend5 = 224, // L50, damage/healing increase
    }

    public enum CDGroup : int
    {
        FeatherRain = 1, // 30.0 max, shared by Eruption
        MountainBuster = 2, // 60.0 max, shared by Shock Strike
        GlassDance = 3, // 90.0 max, shared by Veil of the Whorl
        MagicHammer = 8, // 90.0 max, shared by Candy Cane
        Avail = 9, // 120.0 max
        LevelFiveDeath = 11, // 180.0 max, shared by Ultravibration (120.0 max)
        AngelWhisper = 13, // 300.0 max
        Devour = 12, // 60.0 max
        Surpanakha = 6, // 30.0*4 max
        Quasar = 7, // 60.0 max, shared by J Kick
        TripleTrident = 5, // 90.0 max
        ColdFog = 14, // 90.0 max
        AngelsSnack = 16, // 120.0 max, shared by Dragon Force / Matra Magic
        ChelonianGate = 17, // 30.0 max, shared by The Rose of Destruction / Ruby Dynamics
        BothEnds = 19, // 120.0 max, sharec by Nightbloom
        PhantomFlurry = 18, // 120.0 max
        ForceField = 23, // 120.0 max
        WingedReprobation = 22, // 90.0 max once last charge is used
        SeaShanty = 20, // 120.0 max
        Apokalypsis = 21, // 120.0 max, shared by Being Mortal
        Swiftcast = 44, // 60.0 max
        LucidDreaming = 45, // 60.0 max
        Addle = 46, // 90.0 max
        Surecast = 48, // 120.0 max
    }

    public enum SID : uint
    {
        None = 0,
        Addle = 1203, // applied by Addle to target, -5% phys and -10% magic damage dealt
        LucidDreaming = 1204, // applied by Lucid Dreaming to self, MP restore
        Swiftcast = 167, // applied by Swiftcast to self, next cast is instant
        Surecast = 160, // applied by Surecast to self, knockback immune
        Sleep = 3, // applied by Sleep to target
    }

    public static class Definitions
    {
        public static unsafe bool Unlocked(AID aid) =>
            UIState.Instance()->IsUnlockLinkUnlocked(Service.DataManager.GetExcelSheet<Lumina.Excel.GeneratedSheets.Action>()!.GetRow((uint)aid)!.UnlockLink);

        public static unsafe List<uint> Loaded() => Enumerable.Range(0, 24).Select(i => ActionManager.Instance()->GetActiveBlueMageActionInSlot(i)).ToList();

        public static Dictionary<ActionID, ActionDefinition> SupportedActions;
        static Definitions()
        {
            SupportedActions = CommonDefinitions.CommonActionData(CommonDefinitions.IDPotionInt);
            SupportedActions.OGCD(AID.LucidDreaming, 0, CDGroup.LucidDreaming, 60.0f);
            SupportedActions.OGCD(AID.Addle, 25, CDGroup.Addle, 90.0f);
            SupportedActions.OGCD(AID.Surecast, 0, CDGroup.Surecast, 120.0f);
            SupportedActions.GCDCast(AID.Sleep, 30, 2.5f);

            SupportedActions.GCDCast(AID.WaterCannon, 25, 2f);
            SupportedActions.GCDCast(AID.FlameThrower, 0, 2f);
            SupportedActions.GCDCast(AID.AquaBreath, 0, 2f);
            SupportedActions.GCDCast(AID.FlyingFrenzy, 20, 1f);
            SupportedActions.GCDCast(AID.DrillCannons, 20, 2f);
            SupportedActions.GCDCast(AID.HighVoltage, 0, 2f);
            SupportedActions.GCDCast(AID.Loom, 15, 1f);
            SupportedActions.GCDCast(AID.FinalSting, 3, 2f);
            SupportedActions.GCDCast(AID.SongOfTorment, 25, 2f);
            SupportedActions.GCDCast(AID.Glower, 15, 2f);
            SupportedActions.GCDCast(AID.Plaincracker, 0, 2f);
            SupportedActions.GCDCast(AID.Bristle, 0, 1f);
            SupportedActions.GCDCast(AID.WhiteWind, 0, 2f);
            SupportedActions.GCDCast(AID.LevelFivePetrify, 0, 2f);
            SupportedActions.GCDCast(AID.SharpenedKnife, 3, 1f);
            SupportedActions.GCDCast(AID.IceSpikes, 0, 2f);

            SupportedActions.GCDCast(AID.BloodDrain, 25, 2f);
            SupportedActions.GCDCast(AID.AcornBomb, 25, 2f);
            SupportedActions.GCDCast(AID.BombToss, 25, 2f);
            SupportedActions.GCDCast(AID.OffGuard, 25, 1f);
            SupportedActions.GCDCast(AID.SelfDestruct, 0, 2f);
            SupportedActions.GCDCast(AID.Transfusion, 25, 2f);
            SupportedActions.GCDCast(AID.Faze, 0, 2f);
            SupportedActions.GCD(AID.FlyingSardine, 25);
            SupportedActions.GCDCast(AID.Snort, 0, 2f);
            SupportedActions.GCDCast(AID.FourTonzeWeight, 25, 2f);
            SupportedActions.GCDCast(AID.TheLook, 0, 2f);
            SupportedActions.GCDCast(AID.BadBreath, 0, 2f);
            SupportedActions.GCDCast(AID.Diamondback, 0, 2f);
            SupportedActions.GCDCast(AID.MightyGuard, 0, 2f);
            SupportedActions.GCDCast(AID.StickyTongue, 25, 2f);
            SupportedActions.GCDCast(AID.ToadOil, 0, 2f);

            SupportedActions.GCDCast(AID.TheRamsVoice, 0, 2f);
            SupportedActions.GCDCast(AID.TheDragonsVoice, 0, 2f);
            SupportedActions.GCDCast(AID.Missile, 25, 2f);
            SupportedActions.GCDCast(AID.ThousandNeedles, 0, 6f);
            SupportedActions.GCDCast(AID.InkJet, 0, 2f);
            SupportedActions.GCDCast(AID.FireAngon, 25, 1f);
            SupportedActions.GCDCast(AID.MoonFlute, 0, 2f);
            SupportedActions.GCDCast(AID.TailScrew, 25, 2f);
            SupportedActions.GCDCast(AID.MindBlast, 0, 1f);
            SupportedActions.GCDCast(AID.Doom, 25, 2f);
            SupportedActions.GCDCast(AID.PeculiarLight, 0, 1f);
            SupportedActions.OGCD(AID.FeatherRain, 30, CDGroup.FeatherRain, 30f);
            SupportedActions.OGCD(AID.Eruption, 25, CDGroup.FeatherRain, 30f);
            SupportedActions.OGCD(AID.MountainBuster, 0, CDGroup.MountainBuster, 60f);
            SupportedActions.OGCD(AID.ShockStrike, 25, CDGroup.MountainBuster, 60f);
            SupportedActions.OGCD(AID.GlassDance, 0, CDGroup.GlassDance, 90f);

            SupportedActions.OGCD(AID.VeilOfTheWhorl, 0, CDGroup.GlassDance, 90f);
            SupportedActions.GCDCast(AID.AlpineDraft, 20, 2f);
            SupportedActions.GCDCast(AID.ProteanWave, 0, 2f);
            SupportedActions.GCDCast(AID.Northerlies, 0, 2f);
            SupportedActions.GCDCast(AID.Electrogenesis, 25, 2f);
            SupportedActions.GCDCast(AID.Kaltstrahl, 0, 2f);
            SupportedActions.GCDCast(AID.AbyssalTransfixion, 25, 2f);
            SupportedActions.GCDCast(AID.Chirp, 0, 2f);
            SupportedActions.GCDCast(AID.EerieSoundwave, 0, 2f);
            SupportedActions.GCDCast(AID.PomCure, 30, 1.5f);
            SupportedActions.GCDCast(AID.Gobskin, 0, 2f);
            SupportedActions.GCDCastWithCooldown(AID.MagicHammer, 25, 1f, CDGroup.MagicHammer, 90f);
            SupportedActions.GCDCastWithCooldown(AID.Avail, 10, 1f, CDGroup.Avail, 120f);
            SupportedActions.GCDCast(AID.FrogLegs, 0, 1f);
            SupportedActions.GCDCast(AID.SonicBoom, 25, 1f);
            SupportedActions.GCDCast(AID.Whistle, 0, 1f);

            SupportedActions.GCDCast(AID.WhiteKnightsTour, 20, 2f);
            SupportedActions.GCDCast(AID.BlackKnightsTour, 20, 2f);
            SupportedActions.GCDCastWithCooldown(AID.LevelFiveDeath, 0, 2f, CDGroup.LevelFiveDeath, 180f);
            SupportedActions.GCDCast(AID.Launcher, 0, 2f);
            SupportedActions.GCDCast(AID.PerpetualRay, 25, 3f);
            SupportedActions.GCDCast(AID.Cactguard, 25, 2f);
            SupportedActions.GCDCast(AID.RevengeBlast, 3, 2f);
            SupportedActions.GCDCastWithCooldown(AID.AngelWhisper, 25, 10f, CDGroup.AngelWhisper, 300f);
            SupportedActions.GCDCast(AID.Exuviation, 0, 2f);
            SupportedActions.GCDCast(AID.Reflux, 25, 0f);
            SupportedActions.GCDCastWithCooldown(AID.Devour, 3, 1f, CDGroup.Devour, 60f);
            SupportedActions.GCDCast(AID.CondensedLibra, 25, 2f);
            SupportedActions.GCDCast(AID.AethericMimicry, 25, 1f);
            SupportedActions.OGCDWithCharges(AID.Surpanakha, 0, CDGroup.Surpanakha, 30f, 4);
            SupportedActions.OGCD(AID.Quasar, 0, CDGroup.Quasar, 60f);
            SupportedActions.OGCD(AID.JKick, 25, CDGroup.Quasar, 60f);

            SupportedActions.GCDCastWithCooldown(AID.TripleTrident, 3, 2f, CDGroup.TripleTrident, 90f);
            SupportedActions.GCDCast(AID.Tingle, 20, 2f);
            SupportedActions.GCDCast(AID.TatamiGaeshi, 20, 2f);
            SupportedActions.GCDCastWithCooldown(AID.ColdFog, 0, 2f, CDGroup.ColdFog, 90f);
            SupportedActions.GCD(AID.WhiteDeath, 25f);
            SupportedActions.GCDCast(AID.Stotram, 0, 2f);
            SupportedActions.GCDCast(AID.SaintlyBeam, 25, 2f);
            SupportedActions.GCDCast(AID.FeculentFlood, 20, 2f);
            SupportedActions.GCDCastWithCooldown(AID.AngelsSnack, 0, 2f, CDGroup.AngelsSnack, 120f);
            SupportedActions.GCDCastWithCooldown(AID.ChelonianGate, 0, 2f, CDGroup.ChelonianGate, 30f);
            SupportedActions.GCDCastWithCooldown(AID.TheRoseOfDestruction, 25, 2f, CDGroup.ChelonianGate, 30f);
            SupportedActions.GCDCast(AID.BasicInstinct, 0, 2f);
            SupportedActions.GCDCastWithCooldown(AID.Ultravibration, 0, 2f, CDGroup.LevelFiveDeath, 120f);
            SupportedActions.GCDCast(AID.Blaze, 25, 2f);
            SupportedActions.GCDCast(AID.MustardBomb, 25, 2f);
            SupportedActions.GCDCastWithCooldown(AID.DragonForce, 0, 2f, CDGroup.AngelsSnack, 120f);
            SupportedActions.GCDCast(AID.AetherialSpark, 20, 2f);

            SupportedActions.GCDCast(AID.HydroPull, 0, 2f);
            SupportedActions.GCDCast(AID.MaledictionOfWater, 0, 2f);
            SupportedActions.GCDCast(AID.ChocoMeteor, 25, 2f);
            SupportedActions.GCDCastWithCooldown(AID.MatraMagic, 25, 2f, CDGroup.AngelsSnack, 120f);
            SupportedActions.GCDCast(AID.PeripheralSynthesis, 20, 2f);
            SupportedActions.OGCD(AID.BothEnds, 0, CDGroup.BothEnds, 120f);
            SupportedActions.OGCD(AID.PhantomFlurry, 0, CDGroup.BothEnds, 120f);
            SupportedActions.OGCD(AID.Nightbloom, 0, CDGroup.BothEnds, 120f);
            SupportedActions.GCD(AID.GoblinPunch, 3);
            SupportedActions.GCDCast(AID.RightRound, 0, 2f);
            SupportedActions.GCDCast(AID.Schiltron, 0, 2f);
            SupportedActions.GCDCast(AID.Rehydration, 0, 5f);
            SupportedActions.GCDCast(AID.BreathOfMagic, 0, 2f);
            SupportedActions.GCDCast(AID.WildRage, 0, 5f);
            SupportedActions.GCDCast(AID.PeatPelt, 25, 2f);
            SupportedActions.GCDCast(AID.DeepClean, 25, 2f);

            SupportedActions.GCDCastWithCooldown(AID.RubyDynamics, 0, 2f, CDGroup.ChelonianGate, 30f);
            SupportedActions.GCDCast(AID.DivinationRune, 0, 2f);
            SupportedActions.GCDCast(AID.DimensionalShift, 0, 5f);
            SupportedActions.GCDCast(AID.ConvictionMarcato, 25, 2f);
            SupportedActions.GCDCastWithCooldown(AID.ForceField, 0, 2f, CDGroup.ForceField, 120f);
            SupportedActions.GCDCastWithCooldown(AID.WingedReprobation, 25, 1, CDGroup.WingedReprobation, 90f); // timer only starts on fourth charge expenditure
            SupportedActions.GCDCast(AID.LaserEye, 25, 2f);
            SupportedActions.GCDCastWithCooldown(AID.CandyCane, 25, 1f, CDGroup.MagicHammer, 90f);
            SupportedActions.GCDCast(AID.MortalFlame, 25, 2f);
            SupportedActions.OGCD(AID.SeaShanty, 0, CDGroup.SeaShanty, 120f);
            SupportedActions.OGCD(AID.Apokalypsis, 0, CDGroup.Apokalypsis, 120f);
            SupportedActions.OGCD(AID.BeingMortal, 0, CDGroup.Apokalypsis, 120f);
        }
    }
}
