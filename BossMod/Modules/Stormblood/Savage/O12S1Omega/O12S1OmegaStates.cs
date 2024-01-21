namespace BossMod.Stormblood.Savage.O12S1Omega
{
    class O12S1OmegaStates : StateMachineBuilder
    {
        private O12S1Omega _module;

        private static bool IsEffectivelyDead(Actor? actor) => actor != null && !actor.IsTargetable && actor.HP.Cur <= 1;

        public O12S1OmegaStates(O12S1Omega module) : base(module)
        {
            _module = module;
            SimplePhase(0, SinglePhase, "M/F")
                .Raw.Update = () => IsEffectivelyDead(_module.BossP1M()) && IsEffectivelyDead(_module.BossP1F());
        }

        private void SinglePhase(uint id)
        {
            ComponentCondition<OpticalLaser>(id + 0x20, 0.4f, comp => comp.NumCasts > 0)
                .DeactivateOnExit<OpticalLaser>();
            ComponentCondition<Discharger>(id + 0x40, 6.9f, comp => comp.NumCasts > 0, "Knockback")
                .DeactivateOnExit<Discharger>();
            // beyond defense -> target one with vuln
            // pile pitch -> shared stack minus BD target
            // subject simulation F
            // discharger -> raidwide knockback from boss
            ActorCast(id + 0x30000, _module.BossP1M, AID.CosmoMemoryOU, 5.8f, 5, true, "Enrage");
        }
    }
}
