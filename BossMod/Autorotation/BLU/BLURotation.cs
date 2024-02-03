using System.Collections.Generic;
using System.Linq;

namespace BossMod.BLU
{
    public static class Rotation
    {
        // full state needed for determining next action
        public class State(float[] cooldowns) : CommonRotation.PlayerState(cooldowns)
        {
            public float SwiftcastLeft; // 0 if buff not up, max 10
            public bool TargetMortalFlame;
            public float TargetBoMLeft; // 60s max
            public float TargetDropsyLeft;
            public float TargetSlowLeft;
            public float TargetBindLeft;
            public float TargetLightheadedLeft;
            public float TargetBegrimedLeft;

            public (float Left, int Stacks) SurpanakhasFury; // 3/3 max
            public int ReproStacks;

            public float WaxingLeft; // 15s max
            public float HarmonizedLeft; // 30s max
            public float TinglingLeft; // 15s max
            public float BoostLeft; // 30s max
            public float BrushWithDeathLeft;
            public float ToadOilLeft;
            public float VeilLeft;
            public float ApokalypsisLeft;
            public float FlurryLeft;

            public AID[] BLUSlots = new AID[24];

            public bool OnSlot(AID act) => BLUSlots.Contains(act);

            public override string ToString()
            {
                var slots = string.Join(", ", BLUSlots.Select(x => x.ToString()));
                return $"actions=[{slots}]";
            }
        }

        // strategy configuration
        public class Strategy : CommonRotation.Strategy
        {
            public int NumAOETargets;

            public override string ToString()
            {
                return $"AOE={NumAOETargets}, no-dots={ForbidDOTs}, movement-in={ForceMovementIn:f3}";
            }
        }

        public static AID GetNextBestGCD(State state, Strategy strategy)
        {
            if (!state.TargetMortalFlame && state.OnSlot(AID.MortalFlame))
                return AID.MortalFlame;

            if (
                state.TargetBoMLeft <= state.GCD + 2.22
                && state.OnSlot(AID.BreathOfMagic)
                && state.OnSlot(AID.Bristle)
                && state.RangeToTarget <= 10
                && state.BoostLeft == 0
            )
                return AID.Bristle;

            if (state.TargetBoMLeft <= state.GCD && state.OnSlot(AID.BreathOfMagic) && state.RangeToTarget <= 10)
                return AID.BreathOfMagic;

            if (state.OnSlot(AID.TripleTrident) && state.RangeToTarget < 3)
            {
                if (
                    state.OnSlot(AID.Whistle)
                    && state.CD(CDGroup.TripleTrident) - 2.22 <= state.GCD
                    && state.HarmonizedLeft - 2.22 <= state.GCD
                )
                    return AID.Whistle;

                if (state.CD(CDGroup.TripleTrident) <= state.GCD)
                    return AID.TripleTrident;
            }

            return AID.SonicBoom;
        }

        public static ActionID GetNextBestOGCD(State state, Strategy strategy, float deadline, bool aoe)
        {
            return new();
        }
    }
}
