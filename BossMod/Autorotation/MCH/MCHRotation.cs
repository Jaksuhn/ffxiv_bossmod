using System.Linq;
using System.Numerics;

namespace BossMod.MCH;
public static class Rotation
{
    public class State(float[] cooldowns) : CommonRotation.PlayerState(cooldowns)
    {
        public float CurrentHP;
        public float MaxHP;
        public float CurrentMP;
        public float MaxMP;
        public float TargetCurrentHP;
        public float TargetCurrentMP;

        public AID LastAction;
        public AID LastWeaponskill;
        public AID LastAbility;

        public int Heat;
        public int Battery;
        public int LastSummonBatteryPower;
        public float SummonTimeRemaining;
        public int OverheatedStacks;
        public float OverheatTimeRemaining;
        public float TargetWildfireLeft;
        public bool IsRobotActive;
        public bool IsOverheated;
        public int GaussCharges;
        public int RicochetCharges;
        public int ReassembleCharges;
        public float ReassembleTimeRemaining;
        public float PelotonLeft;

        public int PVP_HeatStacks;
        public float PVP_HeatLeft;
        public float PVP_TargetWildfireLeft;
        public float PVP_OverheatLeft;
        public bool PVP_Overheated;
        public bool PVP_DrillPrimed;
        public bool PVP_BioblasterPrimed;
        public bool PVP_AirAnchorPrimed;
        public bool PVP_ChainsawPrimed;

        public bool Unlocked(AID aid) => Definitions.Unlocked(aid, Level, UnlockProgress);
        public bool Unlocked(TraitID tid) => Definitions.Unlocked(tid, Level, UnlockProgress);
        public bool HasWildfire() => TargetWildfireLeft > 0;
        public bool Reassembled() => ReassembleTimeRemaining > 0;
        public AID ComboLastMove => (AID)ComboLastAction;

        public override string ToString() => $"heat: {PVP_HeatStacks}, overheated: {PVP_Overheated}";
    }

    public class Strategy : CommonRotation.Strategy
    {
        public int NumScattergunTargets; // range 12 90-degree cone
        public int NumBioblasterTargets; // range 12 90-degree cone
    }

    public static AID GetNextBestGCD(State state, Strategy strategy)
    {
        if (!Service.ClientState.IsPvP)
        {
            #region PVE
            // Heatblast
            if (state.IsOverheated && state.Unlocked(AID.HeatBlast))
                return AID.HeatBlast;

            // ChainSaw
            if (state.Unlocked(AID.ChainSaw) && state.CD(CDGroup.ChainSaw) < state.GCD)
                return AID.ChainSaw;

            // Air Anchor/Hotshot
            if ((state.Unlocked(AID.AirAnchor) && state.CD(CDGroup.AirAnchor) < state.GCD) || (!state.Unlocked(AID.AirAnchor) && state.CD(CDGroup.HotShot) <= state.GCD))
                return AID.AirAnchor;

            // Drill
            if (state.Unlocked(AID.Drill) && state.CD(CDGroup.Drill) < state.GCD)
                return AID.Drill;

            return GetNextShotComboAction(state.ComboLastMove);
            #endregion
        }
        else
        {
            #region PVP
            if (!state.PVP_Overheated)
                if (state.PVP_DrillPrimed && state.CD(CDGroup.QueenOverdrive) <= state.GCD)
                    return AID.PVP_Drill;
                else if (state.PVP_BioblasterPrimed && state.CD(CDGroup.QueenOverdrive) <= state.GCD)
                    return AID.PVP_Bioblaster;
                else if (state.PVP_AirAnchorPrimed && state.CD(CDGroup.QueenOverdrive) <= state.GCD)
                    return AID.PVP_AirAnchor;
                else if (state.PVP_ChainsawPrimed && state.CD(CDGroup.QueenOverdrive) <= state.GCD)
                    return AID.PVP_ChainSaw;

            return state.CD(CDGroup.Detonator) <= state.GCD ? AID.PVP_Scattergun : AID.PVP_BlastCharge;
            #endregion
        }
    }

    public static ActionID GetNextBestOGCD(State state, Strategy strategy, float deadline)
    {
        if (!Service.ClientState.IsPvP)
        {
            #region PVE
            // wildfire
            if (state.Heat >= 50 || state.ComboLastMove == AID.Hypercharge && state.CD(CDGroup.Wildfire) <= state.GCD)
            {
                if (!state.IsOverheated && state.LastWeaponskill == AID.AirAnchor)
                    return ActionID.MakeSpell(AID.Wildfire);

                else if (state.IsOverheated && state.LastWeaponskill == AID.HeatBlast)
                    return ActionID.MakeSpell(AID.Wildfire);
            }

            // barrel stabilizer
            if (state.CD(CDGroup.BarrelStabilizer) <= state.GCD && state.Heat <= 55)
                return ActionID.MakeSpell(AID.BarrelStabilizer);

            // queen
            if (state.CD(CDGroup.QueenOverdrive) <= state.GCD && !state.IsOverheated && !state.IsRobotActive)
            {
                if (state.Level >= 90)
                {
                    // First condition
                    if (state.Battery is 50 && strategy.CombatTimer > 61 && strategy.CombatTimer < 68)
                        return ActionID.MakeSpell(AID.RookAutoturret);

                    // Second condition
                    if (state.Battery is 100 && state.LastSummonBatteryPower == 50 && (state.CD(CDGroup.AirAnchor) <= 3 || state.CD(CDGroup.AirAnchor) <= state.GCD))
                        return ActionID.MakeSpell(AID.RookAutoturret);

                    // Third condition
                    if (state.LastSummonBatteryPower == 100 && state.Battery >= 90)
                        return ActionID.MakeSpell(AID.RookAutoturret);

                    // Fourth condition
                    else if (state.LastSummonBatteryPower == 90 && state.CD(CDGroup.Wildfire) < 70 && state.CD(CDGroup.Wildfire) > 45 && state.Battery >= 90)
                        return ActionID.MakeSpell(AID.RookAutoturret);

                    // Fifth condition
                    else if (state.LastSummonBatteryPower != 50 && (state.CD(CDGroup.Wildfire) <= 4 || (state.CD(CDGroup.AirAnchor) <= state.GCD && state.CD(CDGroup.Wildfire) <= state.GCD)))
                        return ActionID.MakeSpell(AID.RookAutoturret);
                }

                else if (state.Unlocked(AID.RookAutoturret) && state.Battery >= 50)
                    return ActionID.MakeSpell(AID.RookAutoturret);
            }

            // hypercharge
            if (state.Heat >= 50 && state.Unlocked(AID.Hypercharge) && !state.IsOverheated)
            {
                //Protection & ensures Hyper charged is double weaved with WF during reopener
                if (state.TargetWildfireLeft > 0 || !state.Unlocked(AID.Wildfire))
                    return ActionID.MakeSpell(AID.Hypercharge);

                if (state.Unlocked(AID.Drill) && state.CD(CDGroup.Drill) >= 8)
                {
                    if (state.Unlocked(AID.AirAnchor) && state.CD(CDGroup.AirAnchor) >= 8)
                    {
                        if (state.Unlocked(AID.ChainSaw) && state.CD(CDGroup.ChainSaw) >= 8)
                        {
                            if (UseHyperchargeStandard(state, strategy))
                                return ActionID.MakeSpell(AID.Hypercharge);
                        }

                        else if (!state.Unlocked(AID.ChainSaw))
                        {
                            if (UseHyperchargeStandard(state, strategy))
                                return ActionID.MakeSpell(AID.Hypercharge);
                        }
                    }

                    else if (!state.Unlocked(AID.AirAnchor))
                    {
                        if (UseHyperchargeStandard(state, strategy))
                            return ActionID.MakeSpell(AID.Hypercharge);
                    }
                }

                else if (!state.Unlocked(AID.Drill))
                {
                    if (UseHyperchargeStandard(state, strategy))
                        return ActionID.MakeSpell(AID.Hypercharge);
                }
            }

            // gauss & ricochet
            if (state.LastWeaponskill == AID.HeatBlast)
            {
                if (state.CD(CDGroup.GaussRound) <= state.GCD && Util.CustomComboFunctions.GetRemainingCharges((uint)AID.GaussRound) >= Util.CustomComboFunctions.GetRemainingCharges((uint)AID.Ricochet))
                    return ActionID.MakeSpell(AID.GaussRound);

                if (state.CD(CDGroup.Ricochet) <= state.GCD && Util.CustomComboFunctions.GetRemainingCharges((uint)AID.Ricochet) >= Util.CustomComboFunctions.GetRemainingCharges((uint)AID.GaussRound))
                    return ActionID.MakeSpell(AID.Ricochet);
            }

            // reassemble
            if (state.HasWildfire() && !state.Reassembled() && Util.CustomComboFunctions.HasCharges((uint)AID.Reassemble) &&
                ((state.Unlocked(AID.ChainSaw) && state.CD(CDGroup.ChainSaw) <= state.GCD) ||
                (state.Unlocked(AID.AirAnchor) && state.CD(CDGroup.AirAnchor) <= state.GCD) ||
                (!state.Unlocked(AID.AirAnchor) && state.Unlocked(AID.Drill) && (state.CD(CDGroup.Drill) <= state.GCD))))
                return ActionID.MakeSpell(AID.Reassemble);

            if (!state.HasWildfire() && state.Unlocked(AID.ChainSaw) && state.CD(CDGroup.ChainSaw) <= state.GCD && !state.Reassembled() && Util.CustomComboFunctions.HasCharges((uint)AID.Reassemble))
                return ActionID.MakeSpell(AID.Reassemble);

            // gauss and ricochet overcap protection
            if (!state.IsOverheated && !state.HasWildfire())
            {
                if (state.CD(CDGroup.GaussRound) <= state.GCD && Util.CustomComboFunctions.GetRemainingCharges((uint)AID.GaussRound) >= Util.CustomComboFunctions.GetMaxCharges((uint)AID.GaussRound))
                    return ActionID.MakeSpell(AID.GaussRound);

                if (state.CD(CDGroup.Ricochet) <= state.GCD && Util.CustomComboFunctions.GetRemainingCharges((uint)AID.Ricochet) >= Util.CustomComboFunctions.GetMaxCharges((uint)AID.Ricochet))
                    return ActionID.MakeSpell(AID.Ricochet);
            }

            // healing
            if (state.CurrentHP / state.MaxHP * 100 <= 20 && state.CD(CDGroup.SecondWind) <= state.GCD)
                return ActionID.MakeSpell(AID.SecondWind);
            #endregion
        }
        else
        {
            #region PVP
            if (!HasHostilesInMaxRange() && (state.CurrentMP <= state.MaxMP / 3 || state.CurrentHP <= state.MaxHP / 3))
                if (Service.ClientState.LocalPlayer?.MaxHp - Service.ClientState.LocalPlayer?.CurrentHp > 15000)
                    return ActionID.MakeSpell(AID.PVP_Recuperate);

            if (Service.ClientState.LocalPlayer?.StatusList.Any(s => Utils.StatusIsRemovable(s.StatusId)) == true)
                return ActionID.MakeSpell(AID.PVP_Purify);

            if (state.PVP_Overheated && state.CD(CDGroup.PVP_Wildfire) <= state.GCD)
                return ActionID.MakeSpell(AID.PVP_Wildfire);

            if (state.CD(CDGroup.QueenOverdrive) <= state.GCD)
                return ActionID.MakeSpell(AID.PVP_Analysis);

            if (state.CD(CDGroup.QueenOverdrive) <= state.GCD)
                return ActionID.MakeSpell(AID.PVP_BishopAutoturret);
            #endregion
        }
        return new();
    }

    public static AID GetNextShotComboAction(AID comboLastMove)
    {
        if (comboLastMove == AID.HeatedSlugShot)
        {
            return AID.HeatedCleanShot;
        }
        else if (comboLastMove == AID.HeatedSplitShot)
        {
            return AID.HeatedSlugShot;
        }

        return AID.HeatedSplitShot;
    }

    public static bool UseHyperchargeStandard(State state, Strategy strategy)
    {
        if (strategy.CombatTimer % 60 == 0 && (state.Heat > 70 || strategy.CombatTimer <= 30) && state.LastWeaponskill != AID.CleanShot)
            return true;

        if (strategy.CombatTimer % 60 > 0)
        {
            if (strategy.CombatTimer % 60 % 2 == 1 && state.Heat >= 90)
                return true;

            if (strategy.CombatTimer % 60 % 2 == 0)
                return true;
        }
        return false;
    }

    private static bool HasHostilesInMaxRange() => Service.ObjectTable.All(o => Vector3.DistanceSquared(o.Position, Service.ClientState.LocalPlayer?.Position ?? Vector3.Zero) > 25);
}