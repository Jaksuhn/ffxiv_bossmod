namespace BossMod
{
    [ConfigDisplay(Parent = typeof(AutorotationConfig))]
    class BLUConfig : ConfigNode
    {
        [PropertyDisplay("Execute optimal rotations on Sonic Boom")]
        public bool FullRotation = true;
    }
}
