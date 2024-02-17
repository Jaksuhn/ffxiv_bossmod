using Dalamud.Game.ClientState.JobGauge.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BossMod.MCH;

internal class Actions : CommonActions
{
    public const int AutoActionST = AutoActionFirstCustom + 0;
    public const int AutoActionAOE = AutoActionFirstCustom + 1;
    public const int AutoMimicD = AutoActionFirstCustom + 2;
    public const int AutoMimicH = AutoActionFirstCustom + 3;
    public const int AutoMimicT = AutoActionFirstCustom + 4;

    private readonly Rotation.State _state;
    private readonly Rotation.Strategy _strategy;
    private readonly MCHConfig _config;

    internal static Dictionary<uint, Lumina.Excel.GeneratedSheets.Action> ActionSheet = Service.DataManager.GetExcelSheet<Lumina.Excel.GeneratedSheets.Action>()!
          .Where(i => i.RowId is not 7)
          .ToDictionary(i => i.RowId, i => i);

    public Actions(Autorotation autorot, Actor player) : base(autorot, player, Definitions.UnlockQuests, Definitions.SupportedActions)
    {
        _config = Service.Config.Get<MCHConfig>();
        _state = new(autorot.Cooldowns);
        _strategy = new();

        _config.Modified += OnConfigModified;
        OnConfigModified(null, EventArgs.Empty);
    }

    public override void Dispose() => _config.Modified -= OnConfigModified;

    public override CommonRotation.PlayerState GetState() => _state;
    public override CommonRotation.Strategy GetStrategy() => _strategy;

    public override Targeting SelectBetterTarget(AIHints.Enemy initial)
    {
        // TODO: min range to better hit clump with cone...
        var bestTarget = initial;
        if (_state.Unlocked(AID.SpreadShot))
        {
            bestTarget = FindBetterTargetBy(bestTarget, 12, e => NumTargetsHitByScattergun(e.Actor)).Target;
        }
        return new(bestTarget, bestTarget.StayAtLongRange ? 25 : 12);
    }

    protected override void QueueAIActions()
    {
        if (_state.Unlocked(AID.HeadGraze))
        {
            var interruptibleEnemy = Autorot.Hints.PotentialTargets.Find(e => e.ShouldBeInterrupted && (e.Actor.CastInfo?.Interruptible ?? false) && e.Actor.Position.InCircle(Player.Position, 25 + e.Actor.HitboxRadius + Player.HitboxRadius));
            SimulateManualActionForAI(ActionID.MakeSpell(AID.HeadGraze), interruptibleEnemy?.Actor, interruptibleEnemy != null);
        }
        if (_state.Unlocked(AID.SecondWind))
            SimulateManualActionForAI(ActionID.MakeSpell(AID.SecondWind), Player, Player.InCombat && Player.HP.Cur < Player.HP.Max * 0.5f);

        if (_state.Unlocked(AID.Peloton))
            SimulateManualActionForAI(ActionID.MakeSpell(AID.Peloton), Player, !Player.InCombat && _state.PelotonLeft < 3 && _strategy.ForceMovementIn == 0);
    }

    protected override NextAction CalculateAutomaticGCD()
    {
        if (Autorot.PrimaryTarget == null || AutoAction < AutoActionAIFight)
            return new();

        var aid = Rotation.GetNextBestGCD(_state, _strategy);
        return MakeResult(aid, Autorot.PrimaryTarget);
    }

    protected override NextAction CalculateAutomaticOGCD(float deadline)
    {
        if (AutoAction < AutoActionAIFight)
            return new();

        ActionID res = new();
        if (_state.CanWeave(deadline - _state.OGCDSlotLength)) // first ogcd slot
            res = Rotation.GetNextBestOGCD(_state, _strategy, deadline - _state.OGCDSlotLength);
        if (!res && _state.CanWeave(deadline)) // second/only ogcd slot
            res = Rotation.GetNextBestOGCD(_state, _strategy, deadline);
        return MakeResult(res, Autorot.PrimaryTarget);
    }

    protected override unsafe void UpdateInternalState(int autoAction)
    {
        FillCommonPlayerState(_state);
        FillCommonStrategy(_strategy, CommonDefinitions.IDPotionInt);

        _strategy.NumScattergunTargets = Autorot.PrimaryTarget != null && autoAction != AutoActionST && _state.Unlocked(AID.SpreadShot) ? NumTargetsHitByScattergun(Autorot.PrimaryTarget) : 0;

        var gauge = Service.JobGauges.Get<MCHGauge>();
        _state.Heat = gauge.Heat;
        _state.SummonTimeRemaining = gauge.SummonTimeRemaining;
        _state.OverheatTimeRemaining = gauge.OverheatTimeRemaining;
        _state.Battery = gauge.Battery;
        _state.IsOverheated = gauge.IsOverheated;
        _state.IsRobotActive = gauge.IsRobotActive;
        _state.LastSummonBatteryPower = gauge.LastSummonBatteryPower;

        _state.CurrentHP = Player.HP.Cur;
        _state.MaxHP = Player.HP.Max;
        _state.CurrentMP = Player.CurMP;
        _state.MaxMP = Service.ClientState.LocalPlayer?.MaxMp ?? 0;

        _state.OverheatedStacks = StatusDetails(Player, SID.Overheated, Player.InstanceID).Stacks;
        _state.TargetWildfireLeft = StatusDetails(Autorot.PrimaryTarget, SID.WildfireTarget, Player.InstanceID).Left;
        _state.ReassembleTimeRemaining = StatusDetails(Player, SID.Reassembled, Player.InstanceID).Left;
        _state.PelotonLeft = StatusDetails(Player, SID.Peloton, Player.InstanceID, 30).Left;

        _state.PVP_TargetWildfireLeft = StatusDetails(Autorot.PrimaryTarget, SID.PVP_WildfireTarget, Player.InstanceID).Left;
        _state.PVP_HeatStacks = StatusDetails(Player, SID.PVP_Heat, Player.InstanceID).Stacks;
        _state.PVP_HeatLeft = StatusDetails(Player, SID.PVP_Heat, Player.InstanceID).Left;
        _state.PVP_OverheatLeft = StatusDetails(Player, SID.PVP_Overheated, Player.InstanceID).Left;
        _state.PVP_Overheated = _state.PVP_OverheatLeft > 0;
        _state.PVP_DrillPrimed = Player.FindStatus(SID.PVP_DrillPrimed, Player.InstanceID) != null;
        _state.PVP_BioblasterPrimed = Player.FindStatus(SID.PVP_BioblasterPrimed, Player.InstanceID) != null;
        _state.PVP_AirAnchorPrimed = Player.FindStatus(SID.PVP_AirAnchorPrimed, Player.InstanceID) != null;
        _state.PVP_ChainsawPrimed = Player.FindStatus(SID.PVP_ChainsawPrimed, Player.InstanceID) != null;
    }

    private int NumTargetsHitByScattergun(Actor primary) => Autorot.Hints.NumPriorityTargetsInAOECone(Player.Position, 12, (primary.Position - Player.Position).Normalized(), 45.Degrees());

    private void OnConfigModified(object? sender, EventArgs args)
    {
        SupportedSpell(AID.PVP_BlastCharge).PlaceholderForAuto =
            SupportedSpell(AID.SplitShot).PlaceholderForAuto =
                _config.FullRotation ? AutoActionST : AutoActionNone;
    }

    protected override void OnActionSucceeded(ActorCastEvent ev)
    {
        _state.LastAction = (AID)ev.Action.ID;

        _ = ActionSheet.TryGetValue((uint)_state.LastAction, out var sheet);
        if (sheet != null)
        {
            switch (sheet.ActionCategory.Value?.RowId)
            {
                case 3: //Weaponskill
                    _state.LastWeaponskill = _state.LastAction;
                    break;
                case 4: //Ability
                    _state.LastAbility = _state.LastAction;
                    break;
            }
        }
    }
}
