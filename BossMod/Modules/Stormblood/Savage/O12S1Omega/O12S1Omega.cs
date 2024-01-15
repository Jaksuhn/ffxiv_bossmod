namespace BossMod.Stormblood.Savage.O12S1Omega
{
    [ModuleInfo(PrimaryActorOID = (uint)OID.OmegaM, CFCID = 594)]
    public class O12S1Omega : BossModule
    {
        public O12S1Omega(WorldState ws, Actor primary) : base(ws, primary, new ArenaBoundsCircle(new(100, 100), 20))
        {

        }
        protected override void DrawEnemies(int pcSlot, Actor pc)
        {
            Arena.Actor(PrimaryActor, ArenaColor.Enemy);
            //foreach (var e in Enemies(OID.Omega))
            //    Arena.Actor(e, ArenaColor.Enemy);
            //foreach (var e in Enemies(OID.OmegaQQQ))
            //    Arena.Actor(e, ArenaColor.Enemy);
            //foreach (var e in Enemies(OID.OmegaQQQQ))
            //    Arena.Actor(e, ArenaColor.Enemy);
        }
    }

    class O12S1OmegaStates : StateMachineBuilder
    {
        public O12S1OmegaStates(BossModule module) : base(module)
        {
            TrivialPhase()
                .ActivateOnEnter<Hints>()
                .ActivateOnEnter<EfficientBladework>();
        }
    }

    public enum OID : uint
    {
        OmegaQQQ = 0x233C,
        OmegaM = 0x247D,
        Omega = 0x247E,
        OmegaQQQQ = 0x247F,
        LeftArmUnit = 0x2480,
        RightArmUnit = 0x2481,
    };

    public enum AID : uint
    {
        AutoAttack = 13181, // Boss->player, no cast, range 5
        SyntheticShield = 13053,
        Suppression = 13125,
        OpticalLaser = 13127,
        BeyondDefense1 = 13099,
        BeyondDefense2 = 13100,
        PilePitch = 13102,
        SubjectSimulationF = 13041,

        EfficientBladework = 13097,
    };

    class Hints : BossComponent
    {
        public override void AddHints(BossModule module, int slot, Actor actor, TextHints hints, MovementHints? movementHints)
        {
            //hints.Add("Hint", false);
            //hints.Add("Risk");
            //if (movementHints != null)
            //    movementHints.Add(actor.Position, actor.Position + new WDir(10, 10), ArenaColor.Danger);
        }

        //public override void AddGlobalHints(BossModule module, GlobalHints hints)
        //{
        //    hints.Add("Global");
        //}

        public override void DrawArenaBackground(BossModule module, int pcSlot, Actor pc, MiniArena arena)
        {
            arena.ZoneCircle(module.Bounds.Center, 10, ArenaColor.AOE);
        }

        public override void DrawArenaForeground(BossModule module, int pcSlot, Actor pc, MiniArena arena)
        {
            arena.Actor(module.Bounds.Center, 0.Degrees(), ArenaColor.PC);
        }
    }

    class EfficientBladework : Components.SelfTargetedAOEs
    {
        public EfficientBladework() : base(ActionID.MakeSpell(AID.EfficientBladework), new AOEShapeCircle(20)) { }
    }

    class Suppression : Components.SelfTargetedAOEs
    {
        public Suppression() : base(ActionID.MakeSpell(AID.Suppression), new AOEShapeRect(40, 10)) { }
    }
}
