using Dalamud.Game.ClientState.JobGauge.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BossMod.BLU
{
    class Actions : CommonActions
    {
        public const int AutoActionST = AutoActionFirstCustom + 0;
        public const int AutoActionAOE = AutoActionFirstCustom + 1;

        private BLUConfig _config;
        private Rotation.State _state;
        private Rotation.Strategy _strategy;
        private bool _aoe;
        private uint _prevMP;

        public Actions(Autorotation autorot, Actor player)
            : base(autorot, player, [], Definitions.SupportedActions)
        {
            _config = Service.Config.Get<BLUConfig>();
            _state = new(autorot.Cooldowns);
            _strategy = new();
            _prevMP = player.CurMP;

            _config.Modified += OnConfigModified;
            OnConfigModified(null, EventArgs.Empty);
        }

        public override void Dispose()
        {
            _config.Modified -= OnConfigModified;
        }

        public override CommonRotation.PlayerState GetState() => _state;
        public override CommonRotation.Strategy GetStrategy() => _strategy;

        public override Targeting SelectBetterTarget(AIHints.Enemy initial)
        {
            // TODO: multidot?..
            var bestTarget = initial;
            return new(bestTarget, bestTarget.StayAtLongRange ? 25 : 15);
        }

        protected override void UpdateInternalState(int autoAction)
        {
            UpdatePlayerState();
            FillCommonStrategy(_strategy, CommonDefinitions.IDPotionInt);
            _aoe = autoAction switch
            {
                AutoActionST => false,
                AutoActionAOE => true, // TODO: consider making AI-like check
                AutoActionAIFight => Autorot.PrimaryTarget != null && Autorot.Hints.NumPriorityTargetsInAOECircle(Autorot.PrimaryTarget.Position, 5) >= 3,
                _ => false, // irrelevant...
            };
        }

        protected override void QueueAIActions()
        {

        }

        protected override NextAction CalculateAutomaticGCD()
        {
            //if (!Player.InCombat && _state.Unlocked(AID.SummonCarbuncle) && !_state.PetSummoned)
            //    return MakeResult(AID.SummonCarbuncle, Player);

            if (Autorot.PrimaryTarget == null || AutoAction < AutoActionAIFight)
                return new();
            var aid = Rotation.GetNextBestGCD(_state, _strategy, _aoe, _strategy.ForceMovementIn < 5);
            return MakeResult(aid, Autorot.PrimaryTarget);
        }

        protected override NextAction CalculateAutomaticOGCD(float deadline)
        {
            if (Autorot.PrimaryTarget == null || AutoAction < AutoActionAIFight)
                return new();

            ActionID res = new();
            if (_state.CanWeave(deadline - _state.OGCDSlotLength)) // first ogcd slot
                res = Rotation.GetNextBestOGCD(_state, _strategy, deadline - _state.OGCDSlotLength, _aoe);
            if (!res && _state.CanWeave(deadline)) // second/only ogcd slot
                res = Rotation.GetNextBestOGCD(_state, _strategy, deadline, _aoe);
            return MakeResult(res, Autorot.PrimaryTarget);
        }

        private void UpdatePlayerState()
        {
            FillCommonPlayerState(_state);
            _prevMP = Player.CurMP;
            _state.SwiftcastLeft = StatusDetails(Player, SID.Swiftcast, Player.InstanceID).Left;
        }

        private void OnConfigModified(object? sender, EventArgs args)
        {
            SupportedSpell(AID.SonicBoom).PlaceholderForAuto = _config.FullRotation ? AutoActionST : AutoActionNone;
        }

        private int NumTargetsHitByAOE(Actor primary) => Autorot.Hints.NumPriorityTargetsInAOECircle(primary.Position, 5);
    }
}
