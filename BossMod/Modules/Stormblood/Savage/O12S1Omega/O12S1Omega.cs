using System;
using System.Collections.Generic;
using System.Linq;

namespace BossMod.Stormblood.Savage.O12S1Omega
{
    [ModuleInfo(PrimaryActorOID = (uint)OID.OmegaM)] // cfc id 594
    public class O12S1Omega(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(100, 100), 20))
    {
        private Actor? OmegaM;
        private Actor? OmegaF;
        private Actor? Omega;

        public Actor? BossP1M() => OmegaM;
        public Actor? BossP1F() => OmegaF;
        public Actor? BossP2() => Omega;

        protected override void DrawEnemies(int pcSlot, Actor pc)
        {
            Arena.Actor(PrimaryActor, ArenaColor.Enemy);
            Arena.Actor(OmegaM, ArenaColor.Enemy);
            Arena.Actor(OmegaF, ArenaColor.Enemy);
            Arena.Actor(Omega, ArenaColor.Enemy);
        }

        protected override void UpdateModule()
        {
            // TODO: this is an ugly hack, think how multi-actor fights can be implemented without it...
            // the problem is that on wipe, any actor can be deleted and recreated in the same frame
            OmegaM ??= StateMachine.ActivePhaseIndex == 0 ? Enemies(OID.OmegaM).FirstOrDefault() : null;
            OmegaF ??= StateMachine.ActivePhaseIndex == 0 ? Enemies(OID.OmegaF).FirstOrDefault() : null;
            //Omega ??= StateMachine.ActivePhaseIndex == 1 ? Enemies(OID.Omega).FirstOrDefault() : null;
        }
    }

    class OpticalLaser : Components.GenericAOEs
    {
        private Actor? _source;
        private DateTime _activation;

        private static AOEShapeRect _shape = new(100, 8);

        public OpticalLaser() : base(ActionID.MakeSpell(AID.OpticalLaser)) { }

        public override IEnumerable<AOEInstance> ActiveAOEs(BossModule module, int slot, Actor actor)
        {
            if (_activation != default && _source != null)
                yield return new(_shape, _source.Position, _source.Rotation, _activation);
        }

        public override void Init(BossModule module)
        {
            _source = module.Enemies(OID.OpticalUnit).FirstOrDefault();
        }
    }

    class Discharger : Components.Knockback
    {
        private Actor? _source;
        private DateTime _activation;

        public Discharger() : base(ActionID.MakeSpell(AID.Discharger)) { }

        public override IEnumerable<Source> Sources(BossModule module, int slot, Actor actor)
        {
            if (_source != null && _source != actor)
                yield return new(_source.Position, 13, _activation);
        }
    }

    class EfficientBladework : Components.SelfTargetedAOEs
    {
        public EfficientBladework() : base(ActionID.MakeSpell(AID.EfficientBladework1), new AOEShapeCircle(20)) { }
    }
}
