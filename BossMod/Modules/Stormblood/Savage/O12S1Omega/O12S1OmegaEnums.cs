namespace BossMod.Stormblood.Savage.O12S1Omega
{
    public enum OID : uint
    {
        OmegaM = 0x247D, // R3.000, x1
        OmegaF = 0x247E, // R3.000, x1
        Omega = 0x247F, // R5.600, x1
        Omega1 = 0x233C, // R0.500, x30
        _Gen_Actor1ea1a1 = 0x1EA1A1, // R2.000, x9, EventObj type
        _Gen_Actor1e8536 = 0x1E8536, // R2.000, x1, EventObj type
        RightArmUnit = 0x2481, // R1.680, x3
        RearPowerUnit = 0x2482, // R6.720, x1
        OpticalUnit = 0x18D6, // R0.500, x1
        LeftArmUnit = 0x2480, // R1.680, x3
        _Gen_Exit = 0x1E850B, // R0.500, x1, EventObj type
    };

    public enum IconID : uint
    {
        _Gen_Icon_62 = 62, // player
        _Gen_Icon_145 = 145, // player
        _Gen_Icon_149 = 149, // player
        _Gen_Icon_146 = 146, // player
        _Gen_Icon_150 = 150, // player
        _Gen_Icon_152 = 152, // player
        _Gen_Icon_147 = 147, // player
        _Gen_Icon_151 = 151, // player
        _Gen_Icon_148 = 148, // player
        _Gen_Icon_23 = 23, // player
        _Gen_Icon_87 = 87, // player
    };

    public enum AID : uint
    {
        _AutoAttack_Attack = 13181, // 247D->player, no cast, single-target
        SyntheticShield = 13053, // 247D->self, 2.0s cast, single-target
        Suppression = 13125, // 247D->self, 3.0s cast, single-target
        OpticalLaser = 13127, // 18D6->self, 7.0s cast, range 100 width 16 rect
        BeyondDefenseSelf = 13099, // 247D->self, 4.9s cast, single-target
        BeyondDefenseTarget = 13100, // 247D->player, no cast, range 5 circle
        PilePitch1 = 13102, // 247D->players, no cast, range 5 circle
        unk01 = 13054, // 247D->self, no cast, single-target
        SubjectSimulationF = 13041, // 247D->self, 2.0s cast, single-target
        unk02 = 13051, // 233C->self, no cast, single-target
        unk03 = 13047, // 247D->self, no cast, single-target
        unk04 = 13050, // 247D/247E->self, no cast, single-target
        unk05 = 13052, // 233C->self, no cast, single-target
        unk06 = 13045, // 247D/247E->self, no cast, single-target
        Discharger = 13095, // 247D/247E->self, no cast, range 100 circle
        ttack = 13094, // 247D/247E->player, no cast, single-target
        SyntheticBlades = 13057, // 247D/247E->self, 2.0s cast, single-target
        AdvancedSuppression1 = 13129, // 247D/247E->self, 3.0s cast, single-target
        SuperliminalMotion = 13108, // 247D/247E->self, 3.0s cast, range 100 ?-degree cone
        AdvancedOpticalLaser = 13130, // 18D6->self, 7.0s cast, range 45 circle
        OptimizedFireIIISelf = 13109, // 247D/247E->self, no cast, single-target
        OptimizedFireIIITarget = 13111, // 233C->players, no cast, range 5 circle
        unk07 = 13058, // 247D/247E->self, no cast, single-target
        SubjectSimulationM = 13044, // 247D->self, 2.0s cast, single-target
        unk08 = 13049, // 247D/247E->self, no cast, single-target
        ElectricSlide = 13140, // 247D/247E->location, no cast, range 6 circle
        unk09 = 13048, // 247D->self, no cast, single-target
        unk10 = 13042, // 247D->self, no cast, single-target
        EfficientBladework1 = 13097, // 247D->self, no cast, range 10 circle
        FirewallM = 13112, // 247D->self, 3.0s cast, range 100 circle
        FirewallF = 13113, // 247E->self, 3.0s cast, range 100 circle
        ResonanceM = 13114, // 247D->self, 3.0s cast, single-target
        ResonanceF = 13115, // 247E->self, 3.0s cast, single-target
        FundamentalSynergyM = 13116, // 247D->self, 5.0s cast, single-target
        FundamentalSynergyF = 13117, // 247E->self, 5.0s cast, single-target
        AdvancedSuppression2 = 13128, // 247D->self, 3.0s cast, single-target
        ElectricSlideF = 13119, // 247E->players, no cast, width 8 rect charge
        ElectricSlideM = 13118, // 247D->player, no cast, width 8 rect charge
        LaserShowerM = 13138, // 247D->self, 4.0s cast, range 100 circle
        LaserShowerF = 13139, // 247E->self, 4.0s cast, range 100 circle
        SolarRayM = 13136, // 247D->player, 5.0s cast, range 5 circle
        SolarRayF = 13137, // 247E->player, 5.0s cast, range 5 circle
        OperationalSynergyM = 13120, // 247D->self, 5.0s cast, single-target
        OperationalSynergyF = 13121, // 247E->self, 5.0s cast, single-target
        _SuperliminalSteel = 13104, // 233C->self, 3.0s cast, range 80 width 36 rect
        SuperliminalSteelF = 13103, // 247E->self, 3.0s cast, single-target
        __SuperliminalSteel = 13105, // 233C->self, 3.0s cast, range 80 width 36 rect
        PilePitch2 = 13101, // 247D->self, 4.9s cast, single-target
        OptimizedBlizzardIII1 = 13106, // 247E->self, no cast, range 100 width 10 cross
        unk11 = 13067, // 247D->location, no cast, ???
        EfficientBladework2 = 13098, // 247D->self, 4.0s cast, range 10 circle
        unk12 = 13068, // 247E->location, no cast, ???
        OptimizedBlizzardIII2 = 13107, // 247E->self, 3.0s cast, range 100 width 10 cross
        OptimizedFireIII = 13110, // 247E->self, 5.0s cast, single-target
        BeyondStrength = 13096, // 247D->self, 3.0s cast, range 40 circle
        AdvancedSuppression3 = 13126, // 247E->self, 3.0s cast, single-target
        OptimizedMeteorF = 13134, // 247E->self, 5.0s cast, single-target
        _OptimizedMeteor = 13135, // 233C->players, 5.0s cast, range 100 circle
        OptimizedSagittariusArrow = 13133, // 247D->self/players, 5.0s cast, range 100 width 10 rect
        CosmoMemoryF = 13123, // 247E->self, 5.0s cast, single-target
        CosmoMemoryM = 13122, // 247D->self, 5.0s cast, single-target
        CosmoMemoryOU = 13124, // 18D6->self, 1.2s cast, range 100 circle
        //unk13 = 13080, // 247D->self, no cast, single-target
        //unk14 = 13081, // 247E->self, no cast, single-target
        //unk15 = 13186, // 247D->location, no cast, single-target
        //unk16 = 13382, // 247E->location, no cast, single-target
        //unk17 = 13383, // 247D->self, no cast, single-target
        //unk18 = 13384, // 247F->self, no cast, single-target
        //ttack = 13184, // 247F->player, no cast, single-target
        //TargetAnalysis = 13164, // 247F->players, 5.0s cast, range 5 circle
        //SavageWaveCannon = 13165, // 247F->self, no cast, ???
        //Patch = 13174, // 247F->self, 4.0s cast, single-target
        //Patch = 13175, // 233C->self, no cast, range 100 circle
        //DiffuseWaveCannon = 13160, // 247F->self, 5.0s cast, single-target
        //DiffuseWaveCannon = 13161, // 233C->self, 5.0s cast, range 100 ?-degree cone
        //OversampledWaveCannon = 13156, // 247F->self, 5.0s cast, single-target
        //OversampledWaveCannon = 13158, // 233C->players, no cast, range 7 circle
        //DiffuseWaveCannon = 13159, // 247F->self, 5.0s cast, single-target
        //OversampledWaveCannon = 13157, // 247F->self, 5.0s cast, single-target
        //IonEfflux = 13143, // 247F->self, 6.0s cast, range 100 circle
        //unk19 = 13185, // 247F->location, no cast, ???
        //Hello, World = 13166, // 247F->self, 6.0s cast, range 100 circle
        //CriticalSynchronizationBug = 13167, // 233C->players, no cast, range 5 circle
        //CriticalOverflowBug = 13543, // 233C->players, no cast, range 20 circle
        //CriticalError = 13182, // 247F->self, 5.0s cast, range 100 circle
        //ArchivePeripheral = 13144, // 247F->self, 4.0s cast, single-target
        //HyperPulse1 = 13146, // 2481->self, 10.0s cast, range 100 width 8 rect
        //HyperPulse2 = 13147, // 2481->self, no cast, range 100 width 8 rect
        //unk20 = 13145, // 247F->self, no cast, single-target
        //IndexAndArchivePeripheral = 13210, // 247F->self, 4.0s cast, single-target
        //HyperPulse = 13148, // 2481->self, no cast, range 100 width 6 rect
        //WaveCannon = 13162, // 247F->self, 8.0s cast, single-target
        //WaveCannon = 13163, // 233C->self, no cast, range 100 width 6 rect
        //CriticalOverflowBug = 13168, // 233C->self, no cast, range 20 circle
        //ArchiveAll = 13149, // 247F->self, 4.0s cast, single-target
        //ElectricSlide = 13155, // 247F->location, 6.0s cast, range 100 circle
        //RearLasers1 = 13153, // 2482->self, 8.0s cast, range 50 width 12 rect
        //RearLasers2 = 13154, // 2482->self, no cast, range 50 width 12 rect
        //DeltaAttack = 13176, // 247F->self, 3.0s cast, single-target
        //Floodlight = 13178, // 233C->location, 3.0s cast, range 6 circle
        //OptimizedFireIII = 13177, // 233C->player, 5.0s cast, range 5 circle
        //Spotlight = 13179, // 233C->player, 5.0s cast, range 6 circle
        //ColossalBlow = 13151, // 2481->self, 21.0s cast, range 11 circle
        //ColossalBlow = 13152, // 2480->self, 21.0s cast, range 11 circle
        //unk21 = 13150, // 247F->self, no cast, single-target
    };

    public enum TetherID : uint
    {
        _Gen_Tether_12 = 12, // OmegaM->Omega
        _Gen_Tether_16 = 16, // OmegaM->Omega
    };


    public enum SID : uint
    {
        _Gen_MagicVulnerabilityUp = 1138, // OmegaM/Omega->player, extra=0x0
        _Gen_Superfluid = 1676, // OmegaM/Omega->OmegaM/Omega, extra=0xC8
        _Gen_OmegaF = 1675, // OmegaM/Omega->OmegaM/Omega, extra=0xC7
        _Gen_PhysicalVulnerabilityUp = 695, // OmegaM/Omega->player, extra=0x0
        _Gen_OmegaM = 1674, // OmegaM->OmegaM, extra=0x0
        _Gen_PacketFilterF = 1661, // none->player, extra=0x0
        _Gen_PacketFilterM = 1660, // none->player, extra=0x0
        _Gen_RemoteResonance = 1663, // none->OmegaM/Omega, extra=0x0
        _Gen_HealingMagicDown = 697, // Omega/OmegaM->player, extra=0x0
        _Gen_VulnerabilityUp = 202, // Omega/OmegaM->player, extra=0x1/0x2
        _Gen_DamageDown = 1016, // Omega/OmegaM->player, extra=0x1/0x2
        _Gen_Weakness = 43, // none->player, extra=0x0
        _Gen_Transcendent = 418, // none->player, extra=0x0
        _Gen_LocalResonance = 1662, // none->OmegaM/Omega, extra=0x0
        _Gen_DamageUp = 290, // none->OmegaM/Omega, extra=0x0
        _Gen_VulnerabilityDown = 350, // none->OmegaM/Omega, extra=0x0
        _Gen_InfiniteLimit = 1659, // none->OmegaM/Omega, extra=0x0
        _Gen_Prey = 562, // none->player, extra=0x0
        _Gen_BrinkOfDeath = 44, // none->player, extra=0x0

    };
}
