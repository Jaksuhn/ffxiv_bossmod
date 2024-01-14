using System.Collections.Generic;
using System.Linq;

namespace BossMod.BLU
{
    public static class Rotation
    {
        // full state needed for determining next action
        public class State : CommonRotation.PlayerState
        {
            public float SwiftcastLeft; // 0 if buff not up, max 10
            public List<uint> LoadedSpells = Definitions.Loaded();

            public State(float[] cooldowns) : base(cooldowns) { }

            public bool Unlocked(AID aid) => Definitions.Unlocked(aid);

            public override string ToString()
            {
                return $"RB={RaidBuffsLeft:f1}, PotCD={PotionCD:f1}, GCD={GCD:f3}, ALock={AnimationLock:f3}+{AnimationLockDelay:f3}, lvl={Level}/{UnlockProgress}";
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

        public static AID GetNextBestGCD(State state, Strategy strategy, bool aoe, bool moving)
        {
            return (AID)state.LoadedSpells.FirstOrDefault(x => Service.DataManager.GetExcelSheet<Lumina.Excel.GeneratedSheets.Action>()?.GetRow(x)!.CooldownGroup == 58);
        }

        public static ActionID GetNextBestOGCD(State state, Strategy strategy, float deadline, bool aoe)
        {
            return new();
        }
    }
}
