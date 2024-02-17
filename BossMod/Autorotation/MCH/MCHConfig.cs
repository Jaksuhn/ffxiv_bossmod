namespace BossMod.MCH;

[ConfigDisplay(Parent = typeof(AutorotationConfig))]
internal class MCHConfig : ConfigNode
{
    [PropertyDisplay("Execute optimal rotations on Blast Charge (PVP)")]
    public bool FullRotation = true;
}
