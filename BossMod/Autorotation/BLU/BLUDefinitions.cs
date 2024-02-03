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

    //public enum AID : uint
    //{
    //    None = 0,

    //    // GCDs
    //    Whistle = 18309, // L1, 1.0s cast, range 0, single-target 0/0, targets=self, animLock=???
    //    DivineCataract = 23274, // L1, instant, range 0, AOE circle 10/0, targets=self, animLock=???
    //    FeculentFlood = 23271, // L1, 2.0s cast, range 20, AOE rect 20/4, targets=hostile, animLock=???
    //    SaintlyBeam = 23270, // L1, 2.0s cast, range 25, AOE circle 6/0, targets=hostile, animLock=???
    //    Stotram = 23269, // L1, 2.0s cast, range 0, AOE circle 15/0, targets=self, animLock=???
    //    WhiteDeath = 23268, // L1, instant, range 25, single-target 0/0, targets=hostile, animLock=???
    //    TatamiGaeshi = 23266, // L1, 2.0s cast, range 20, AOE rect 20/5, targets=hostile, animLock=???
    //    Tingle = 23265, // L1, 2.0s cast, range 20, AOE circle 6/0, targets=hostile, animLock=???
    //    AethericMimicry = 19240, // L1, instant, range 0, single-target 0/0, targets=self, animLock=???
    //    AethericMimicry = 19239, // L1, instant, range 0, single-target 0/0, targets=self, animLock=???
    //    BasicInstinct = 23276, // L1, 2.0s cast, range 0, single-target 0/0, targets=self, animLock=???
    //    AethericMimicry = 19238, // L1, instant, range 0, single-target 0/0, targets=self, animLock=???
    //    AethericMimicry = 18322, // L1, 1.0s cast, range 25, single-target 0/0, targets=party/friendly, animLock=???
    //    CondensedLibra = 18321, // L1, 2.0s cast, range 25, single-target 0/0, targets=hostile, animLock=???
    //    Reflux = 18319, // L1, 2.0s cast, range 25, single-target 0/0, targets=hostile, animLock=???
    //    Exuviation = 18318, // L1, 2.0s cast, range 0, AOE circle 6/0, targets=self, animLock=???
    //    RevengeBlast = 18316, // L1, 2.0s cast, range 3, single-target 0/0, targets=hostile, animLock=???
    //    Cactguard = 18315, // L1, 1.0s cast, range 25, single-target 0/0, targets=party, animLock=???
    //    PerpetualRay = 18314, // L1, 3.0s cast, range 25, single-target 0/0, targets=hostile, animLock=???
    //    Launcher = 18313, // L1, 2.0s cast, range 0, AOE circle 15/0, targets=self, animLock=???
    //    BlackKnightsTour = 18311, // L1, 2.0s cast, range 20, AOE rect 20/4, targets=hostile, animLock=???
    //    WhiteKnightsTour = 18310, // L1, 2.0s cast, range 20, AOE rect 20/4, targets=hostile, animLock=???
    //    MustardBomb = 23279, // L1, 2.0s cast, range 25, AOE circle 6/0, targets=hostile, animLock=???
    //    MortalFlame = 34579, // L1, 2.0s cast, range 25, single-target 0/0, targets=hostile, animLock=???
    //    LaserEye = 34577, // L1, 2.0s cast, range 25, AOE circle 8/0, targets=hostile, animLock=???
    //    ConvictionMarcato = 34574, // L1, 2.0s cast, range 25, AOE rect 25/5, targets=hostile, animLock=???
    //    DimensionalShift = 34573, // L1, 5.0s cast, range 0, AOE circle 10/0, targets=self, animLock=???
    //    DivinationRune = 34572, // L1, 2.0s cast, range 0, AOE cone 15/0, targets=self, animLock=???
    //    DeepClean = 34570, // L1, 2.0s cast, range 25, AOE circle 6/0, targets=hostile, animLock=???
    //    PeatPelt = 34569, // L1, 2.0s cast, range 25, AOE circle 6/0, targets=hostile, animLock=???
    //    WildRage = 34568, // L1, 5.0s cast, range 0, AOE circle 10/0, targets=self, animLock=???
    //    BreathOfMagic = 34567, // L1, 2.0s cast, range 0, AOE cone 10/0, targets=self, animLock=???
    //    Blaze = 23278, // L1, 2.0s cast, range 25, AOE circle 6/0, targets=hostile, animLock=???
    //    Rehydration = 34566, // L1, 5.0s cast, range 0, single-target 0/0, targets=self, animLock=???
    //    RightRound = 34564, // L1, 2.0s cast, range 0, AOE circle 8/0, targets=self, animLock=???
    //    GoblinPunch = 34563, // L1, instant, range 3, single-target 0/0, targets=hostile, animLock=???
    //    Stotram = 23416, // L1, 2.0s cast, range 0, AOE circle 15/0, targets=self, animLock=???
    //    PhantomFlurry = 23289, // L1, instant, range 0, AOE cone 16/0, targets=self, animLock=???
    //    PeripheralSynthesis = 23286, // L1, 2.0s cast, range 20, AOE rect 20/4, targets=hostile, animLock=???
    //    ChocoMeteor = 23284, // L1, 2.0s cast, range 25, AOE circle 8/0, targets=hostile, animLock=???
    //    MaledictionOfWater = 23283, // L1, 2.0s cast, range 0, AOE rect 15/6, targets=self, animLock=???
    //    HydroPull = 23282, // L1, 2.0s cast, range 0, AOE circle 15/0, targets=self, animLock=???
    //    AetherialSpark = 23281, // L1, 2.0s cast, range 20, AOE rect 20/4, targets=hostile, animLock=???
    //    Schiltron = 34565, // L1, 2.0s cast, range 0, single-target 0/0, targets=self, animLock=???
    //    FrogLegs = 18307, // L1, 1.0s cast, range 0, AOE circle 4/0, targets=self, animLock=???
    //    ToadOil = 11410, // L1, 2.0s cast, range 0, single-target 0/0, targets=self, animLock=???
    //    Transfusion = 11409, // L1, 2.0s cast, range 25, single-target 0/0, targets=party, animLock=???
    //    SelfDestruct = 11408, // L1, 2.0s cast, range 0, AOE circle 20/0, targets=self, animLock=???
    //    FinalSting = 11407, // L1, 2.0s cast, range 3, single-target 0/0, targets=hostile, animLock=???
    //    WhiteWind = 11406, // L1, 2.0s cast, range 0, AOE circle 15/0, targets=self, animLock=???
    //    Missile = 11405, // L1, 2.0s cast, range 25, single-target 0/0, targets=hostile, animLock=???
    //    Glower = 11404, // L1, 2.0s cast, range 15, AOE rect 15/3, targets=hostile, animLock=???
    //    Faze = 11403, // L1, 2.0s cast, range 0, AOE cone 4/0, targets=self, animLock=???
    //    FlameThrower = 11402, // L1, 2.0s cast, range 0, AOE cone 8/0, targets=self, animLock=???
    //    Loom = 11401, // L1, 1.0s cast, range 15, Ground circle 1/0, targets=area, animLock=???
    //    SharpenedKnife = 11400, // L1, 1.0s cast, range 3, single-target 0/0, targets=hostile, animLock=???
    //    TheLook = 11399, // L1, 2.0s cast, range 0, AOE cone 6/0, targets=self, animLock=???
    //    DrillCannons = 11398, // L1, 2.0s cast, range 20, AOE rect 20/3, targets=hostile, animLock=???
    //    SonicBoom = 18308, // L1, 1.0s cast, range 25, single-target 0/0, targets=hostile, animLock=0.100s
    //    ThousandNeedles = 11397, // L1, 6.0s cast, range 0, AOE circle 4/0, targets=self, animLock=???
    //    BloodDrain = 11395, // L1, 2.0s cast, range 25, single-target 0/0, targets=hostile, animLock=???
    //    MindBlast = 11394, // L1, 1.0s cast, range 0, AOE circle 6/0, targets=self, animLock=???
    //    Bristle = 11393, // L1, 1.0s cast, range 0, single-target 0/0, targets=self, animLock=???
    //    AcornBomb = 11392, // L1, 2.0s cast, range 25, AOE circle 6/0, targets=hostile, animLock=???
    //    Plaincracker = 11391, // L1, 2.0s cast, range 0, AOE circle 6/0, targets=self, animLock=???
    //    AquaBreath = 11390, // L1, 2.0s cast, range 0, AOE cone 8/0, targets=self, animLock=???
    //    FlyingFrenzy = 11389, // L1, 1.0s cast, range 20, AOE circle 6/0, targets=hostile, animLock=???
    //    BadBreath = 11388, // L1, 2.0s cast, range 0, AOE cone 8/0, targets=self, animLock=???
    //    HighVoltage = 11387, // L1, 2.0s cast, range 0, AOE circle 12/0, targets=self, animLock=???
    //    SongOfTorment = 11386, // L1, 2.0s cast, range 25, single-target 0/0, targets=hostile, animLock=???
    //    WaterCannon = 11385, // L1, 2.0s cast, range 25, single-target 0/0, targets=hostile, animLock=???
    //    FourTonzeWeight = 11384, // L1, 2.0s cast, range 25, AOE circle 4/0, targets=area, animLock=???
    //    Snort = 11383, // L1, 2.0s cast, range 0, AOE cone 6/0, targets=self, animLock=???
    //    BombToss = 11396, // L1, 2.0s cast, range 25, AOE circle 6/0, targets=area, animLock=???
    //    StickyTongue = 11412, // L1, 2.0s cast, range 25, single-target 0/0, targets=hostile, animLock=???
    //    LevelFivePetrify = 11414, // L1, 2.0s cast, range 0, AOE cone 6/0, targets=self, animLock=???
    //    Gobskin = 18304, // L1, 2.0s cast, range 0, AOE circle 20/0, targets=self, animLock=???
    //    PomCure = 18303, // L1, 1.5s cast, range 30, single-target 0/0, targets=self/party/friendly, animLock=???
    //    EerieSoundwave = 18302, // L1, 2.0s cast, range 0, AOE circle 6/0, targets=self, animLock=???
    //    Chirp = 18301, // L1, 2.0s cast, range 0, AOE circle 3/0, targets=self, animLock=???
    //    AbyssalTransfixion = 18300, // L1, 2.0s cast, range 25, single-target 0/0, targets=hostile, animLock=???
    //    Kaltstrahl = 18299, // L1, 2.0s cast, range 0, AOE cone 6/0, targets=self, animLock=???
    //    Electrogenesis = 18298, // L1, 2.0s cast, range 25, AOE circle 6/0, targets=hostile, animLock=???
    //    Northerlies = 18297, // L1, 2.0s cast, range 0, AOE cone 6/0, targets=self, animLock=???
    //    ProteanWave = 18296, // L1, 2.0s cast, range 0, AOE cone 15/0, targets=self, animLock=???
    //    AlpineDraft = 18295, // L1, 2.0s cast, range 20, AOE rect 20/4, targets=hostile, animLock=???
    //    TailScrew = 11413, // L1, 2.0s cast, range 25, single-target 0/0, targets=hostile, animLock=???
    //    MoonFlute = 11415, // L1, 2.0s cast, range 0, single-target 0/0, targets=self, animLock=???
    //    Doom = 11416, // L1, 2.0s cast, range 25, single-target 0/0, targets=hostile, animLock=???
    //    MightyGuard = 11417, // L1, 2.0s cast, range 0, single-target 0/0, targets=self, animLock=???
    //    IceSpikes = 11418, // L1, 2.0s cast, range 0, single-target 0/0, targets=self, animLock=???
    //    TheDragonsVoice = 11420, // L1, 2.0s cast, range 0, Enemy AOE donut 20/0, targets=self, animLock=???
    //    TheRamsVoice = 11419, // L1, 2.0s cast, range 0, AOE circle 6/0, targets=self, animLock=???
    //    FlyingSardine = 11423, // L1, instant, range 25, single-target 0/0, targets=hostile, animLock=???
    //    Diamondback = 11424, // L1, 2.0s cast, range 0, single-target 0/0, targets=self, animLock=???
    //    FireAngon = 11425, // L1, 1.0s cast, range 25, AOE circle 4/0, targets=hostile, animLock=???
    //    InkJet = 11422, // L1, 2.0s cast, range 0, AOE cone 6/0, targets=self, animLock=???
    //    Sleep = 25880, // L10, 2.5s cast, range 30, AOE circle 5/0, targets=hostile, animLock=???

    //    // oGCDs
    //    TheRoseOfDestruction = 23275, // L1, 2.0s cast, 30.0s CD (group 16), range 25, single-target 0/0, targets=hostile, animLock=???
    //    ChelonianGate = 23273, // L1, 2.0s cast, 30.0s CD (group 16), range 0, single-target 0/0, targets=self, animLock=???
    //    AngelsSnack = 23272, // L1, 2.0s cast, 120.0s CD (group 15), range 0, AOE circle 20/0, targets=self, animLock=???
    //    ColdFog = 23267, // L1, 2.0s cast, 90.0s CD (group 13), range 0, single-target 0/0, targets=self, animLock=???
    //    TripleTrident = 23264, // L1, 2.0s cast, 90.0s CD (group 4), range 3, single-target 0/0, targets=hostile, animLock=???
    //    Quasar = 18324, // L1, instant, 60.0s CD (group 6), range 0, AOE circle 15/0, targets=self, animLock=???
    //    Surpanakha = 18323, // L1, instant, 30.0s CD (group 5) (4 charges), range 0, AOE cone 16/0, targets=self, animLock=???
    //    Devour = 18320, // L1, 1.0s cast, 60.0s CD (group 11), range 3, single-target 0/0, targets=hostile, animLock=???
    //    AngelWhisper = 18317, // L1, 10.0s cast, 300.0s CD (group 12), range 25, single-target 0/0, targets=party/friendly, animLock=???
    //    LevelFiveDeath = 18312, // L1, 2.0s cast, 180.0s CD (group 10), range 0, AOE circle 6/0, targets=self, animLock=???
    //    JKick = 18325, // L1, instant, 60.0s CD (group 6), range 25, AOE circle 6/0, targets=hostile, animLock=???
    //    Ultravibration = 23277, // L1, 2.0s cast, 120.0s CD (group 10), range 0, AOE circle 6/0, targets=self, animLock=???
    //    SeaShanty = 34580, // L1, instant, 120.0s CD (group 19), range 0, AOE circle 10/0, targets=self, animLock=???
    //    CandyCane = 34578, // L1, 1.0s cast, 90.0s CD (group 7), range 25, AOE circle 5/0, targets=hostile, animLock=???
    //    WingedReprobation = 34576, // L1, 1.0s cast, 90.0s CD (group 21), range 25, AOE rect 25/5, targets=hostile, animLock=???
    //    ForceField = 34575, // L1, 2.0s cast, 120.0s CD (group 22), range 0, single-target 0/0, targets=self, animLock=???
    //    RubyDynamics = 34571, // L1, 2.0s cast, 30.0s CD (group 16), range 0, AOE cone 12/0, targets=self, animLock=???
    //    Nightbloom = 23290, // L1, instant, 120.0s CD (group 18), range 0, AOE circle 10/0, targets=self, animLock=???
    //    PhantomFlurry = 23288, // L1, instant, 120.0s CD (group 17), range 0, AOE cone 8/0, targets=self, animLock=???
    //    BothEnds = 23287, // L1, instant, 120.0s CD (group 18), range 0, AOE circle 20/0, targets=self, animLock=???
    //    MatraMagic = 23285, // L1, 2.0s cast, 120.0s CD (group 15), range 25, single-target 0/0, targets=hostile, animLock=???
    //    DragonForce = 23280, // L1, 2.0s cast, 120.0s CD (group 15), range 0, single-target 0/0, targets=self, animLock=???
    //    Apokalypsis = 34581, // L1, instant, 120.0s CD (group 20), range 0, single-target 25/0, targets=self, animLock=???
    //    BeingMortal = 34582, // L1, instant, 120.0s CD (group 20), range 0, AOE circle 10/0, targets=self, animLock=???
    //    OffGuard = 11411, // L1, 1.0s cast, 60.0s CD (group 3), range 25, single-target 0/0, targets=hostile, animLock=???
    //    Avail = 18306, // L1, 1.0s cast, 120.0s CD (group 8), range 10, single-target 0/0, targets=party, animLock=???
    //    MagicHammer = 18305, // L1, 1.0s cast, 90.0s CD (group 7), range 25, AOE circle 8/0, targets=hostile, animLock=???
    //    VeilOfTheWhorl = 11431, // L1, instant, 90.0s CD (group 2), range 0, single-target 0/0, targets=self, animLock=???
    //    ShockStrike = 11429, // L1, instant, 60.0s CD (group 1), range 25, AOE circle 3/0, targets=hostile, animLock=???
    //    GlassDance = 11430, // L1, instant, 90.0s CD (group 2), range 0, AOE cone 12/0, targets=self, animLock=???
    //    MountainBuster = 11428, // L1, instant, 60.0s CD (group 1), range 0, AOE cone 6/0, targets=self, animLock=???
    //    PeculiarLight = 11421, // L1, 1.0s cast, 60.0s CD (group 3), range 0, AOE circle 6/0, targets=self, animLock=???
    //    FeatherRain = 11426, // L1, instant, 30.0s CD (group 0), range 30, AOE circle 5/0, targets=area, animLock=???
    //    Eruption = 11427, // L1, instant, 30.0s CD (group 0), range 25, AOE circle 5/0, targets=area, animLock=???
    //    Addle = 7560, // L8, instant, 90.0s CD (group 46), range 25, single-target 0/0, targets=hostile, animLock=???
    //    LucidDreaming = 7562, // L14, instant, 60.0s CD (group 45), range 0, single-target 0/0, targets=self, animLock=???
    //    Swiftcast = 7561, // L18, instant, 60.0s CD (group 44), range 0, single-target 0/0, targets=self, animLock=???
    //    Surecast = 7559, // L44, instant, 120.0s CD (group 48), range 0, single-target 0/0, targets=self, animLock=???
    //}

    public enum TraitID : uint
    {
        None = 0,
        Learning = 219, // L1, allows learning spells
        MaimAndMend = 220, // L10, damage/healing increase
        MaimAndMendII = 221, // L20, damage/healing increase
        MaimAndMendIII = 222, // L30, damage/healing increase
        MaimAndMendIV = 223, // L40, damage/healing increase
        MaimAndMendV = 224, // L50, damage/healing increase
    }

    //public enum CDGroup : int
    //{
    //    FeatherRain = 0, // 30.0 max, shared by Feather Rain, Eruption
    //    FeatherRain = 1, // 60.0 max, shared by Shock Strike, Mountain Buster
    //    MountainBuster = 2, // 90.0 max, shared by Veil of the Whorl, Glass Dance
    //    GlassDance = 3, // 60.0 max, shared by Off-guard, Peculiar Light
    //    TripleTrident = 4, // 90.0 max
    //    TripleTrident = 5, // 4*30.0 max
    //    Surpanakha = 6, // 60.0 max, shared by Quasar, J Kick
    //    Quasar = 7, // 90.0 max, shared by Candy Cane, Magic Hammer
    //    MagicHammer = 8, // 120.0 max
    //    Level5Death = 10, // variable max, shared by Level 5 Death, Ultravibration
    //    LevelFiveDeath = 11, // 60.0 max
    //    Devour = 12, // 300.0 max
    //    AngelWhisper = 13, // 90.0 max
    //    AngelsSnack = 15, // 120.0 max, shared by Angel's Snack, Matra Magic, Dragon Force
    //    AngelsSnack = 16, // 30.0 max, shared by The Rose of Destruction, Chelonian Gate, Ruby Dynamics
    //    ChelonianGate = 17, // 120.0 max
    //    PhantomFlurry = 18, // 120.0 max, shared by Nightbloom, Both Ends
    //    BothEnds = 19, // 120.0 max
    //    SeaShanty = 20, // 120.0 max, shared by Apokalypsis, Being Mortal
    //    Apokalypsis = 21, // 90.0 max
    //    WingedReprobation = 22, // 120.0 max
    //    Swiftcast = 44, // 60.0 max
    //    LucidDreaming = 45, // 60.0 max
    //    Addle = 46, // 90.0 max
    //    Surecast = 48, // 120.0 max
    //}


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
        AethericMimicryHealer = 2126, // applied by Aetheric Mimicry to self
        AethericMimicryDPS = 2125, // applied by Aetheric Mimicry to self
        AethericMimicryTank = 2124, // applied by Aetheric Mimicry to self
        PhantomFlurry = 2502, // applied by Phantom Flurry to self
        LucidDreaming = 1204, // applied by Lucid Dreaming to self
        Swiftcast = 167, // applied by Swiftcast to self
        Surecast = 160, // applied by Surecast to self
        Addle = 1203, // applied by Addle to target
        Sleep = 3, // applied by Sleep, Acorn Bomb, Chirp to target
        Conked = 2115, // applied by Magic Hammer to target
        Gobskin = 2114, // applied by Gobskin to self
        Diamondback = 1722, // applied by Diamondback to self
        Bleeding = 1714, // applied by Song of Torment, Aetherial Spark to target
        OffGuard = 1717, // applied by Off-guard to target
        WaxingNocturne = 1718, // applied by Moon Flute to self
        SurpanakhasFury = 2130, // applied by Surpanakha to self
        Harmonized = 2118, // applied by Whistle to self
        Tingling = 2492, // applied by Tingle to self
        WingedReprobation = 3640, // applied by Winged Reprobation to self
        Boost = 1716, // applied by Bristle to self
        DeepFreeze = 1731, // applied by the Ram's Voice to target
        IceSpikes = 1720, // applied by Ice Spikes to self
        Petrification = 1, // applied by Level 5 Petrify to target
        Paralysis = 17, // applied by Glower, High Voltage, the Dragon's Voice, Mind Blast, Abyssal Transfixion to target
        Dropsy = 1736, // applied by Aqua Breath to target
        Stun = 2, // applied by Bomb Toss, Tatami-gaeshi to target
        BrushWithDeath = 2127, // applied by Self-destruct to self
        Heavy = 14, // applied by 4-tonze Weight to target
        Poison = 18, // applied by Bad Breath to target
        MightyGuard = 1719, // applied by Mighty Guard to self
        ToadOil = 1737, // applied by Toad Oil to self
        Blind = 15, // applied by Ink Jet to target
        PeculiarLight = 1721, // applied by Peculiar Light to target
        VeilOfTheWhorl = 1724, // applied by Veil of the Whorl to self
        MeatShield = 2117, // applied by Avail to target
        MeatilyShielded = 2116, // applied by Avail to self
        Slow = 9, // applied by White Knight's Tour to target
        Bind = 13, // applied by Black Knight's Tour to target
        PerpetualStun = 142, // applied by Perpetual Ray to target
        Cactguard = 2119, // applied by Cactguard to target
        RefluxHeavy = 2158, // applied by Reflux to target
        HPBoost = 2120, // applied by Devour to self
        UmbralAttenuation = 2122, // applied by Condensed Libra to target
        AstralAttenuation = 2121, // applied by Condensed Libra to target
        PhysicalAttenuation = 2123, // applied by Condensed Libra to target
        DragonForce = 2500, // applied by Dragon Force to self
        Lightheaded = 2501, // applied by Peripheral Synthesis to target
        IncendiaryBurns = 2499, // applied by Mustard Bomb to target
        BreathOfMagic = 3712, // applied by Breath of Magic to target
        Schiltron = 3631, // applied by Schiltron to self
        Begrimed = 3636, // applied by Peat Pelt to target
        SpickAndSpan = 3637, // applied by Deep Clean to self
        PhysicalVulnerabilityDown = 3638, // applied by Force Field to self
        MagicVulnerabilityDown = 3639, // applied by Force Field to self
        CandyCane = 3642, // applied by Candy Cane to target
        MortalFlame = 3643, // applied by Mortal Flame to target
        Apokalypsis = 3644, // applied by Apokalypsis to self
    }

    public static class Definitions
    {
        public static unsafe bool Unlocked(AID aid) =>
            UIState.Instance()->IsUnlockLinkUnlocked(Service.DataManager.GetExcelSheet<Lumina.Excel.GeneratedSheets.Action>()!.GetRow((uint)aid)!.UnlockLink);

        public static unsafe AID[] Loaded() => (AID[])Enumerable.Range(0, 24).Select(i => (AID)ActionManager.Instance()->GetActiveBlueMageActionInSlot(i));

        public static Dictionary<ActionID, ActionDefinition> SupportedActions;

        public static uint[] UnlockQuests = { };

        public static bool Unlocked(AID aid, int level, int questProgress)
        {
            return aid switch
            {
                AID.Addle => level >= 8,
                AID.Sleep => level >= 10,
                AID.LucidDreaming => level >= 14,
                AID.Swiftcast => level >= 18,
                AID.Surecast => level >= 44,
                _ => true,
            };
        }

        public static bool Unlocked(TraitID tid, int level, int questProgress)
        {
            return tid switch
            {
                TraitID.MaimAndMend => level >= 10,
                TraitID.MaimAndMendII => level >= 20,
                TraitID.MaimAndMendIII => level >= 30,
                TraitID.MaimAndMendIV => level >= 40,
                TraitID.MaimAndMendV => level >= 50,
                _ => true,
            };
        }

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
