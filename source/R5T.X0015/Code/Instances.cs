using System;


namespace R5T.X0015
{
    public static class Instances
    {
        public static B0006.ISyntaxGenerator SyntaxGenerator { get; } = B0006.SyntaxGenerator.Instance;
        public static B0007.ISpacingGenerator SpacingGenerator { get; } = B0007.SpacingGenerator.Instance;
    }
}
