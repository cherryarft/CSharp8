using System;

namespace Ex
{
    readonly struct PointOld
    {
        internal int X { get; }
        internal readonly int Y;

        public override string ToString() => $"{X} : {Y}";
    }

    struct PointNew
    {
        internal int X { get; }
        internal readonly int Y;

        internal int Z;
        internal void IncreaseZ() => ++Z;

        public override readonly string ToString() => $"{X} : {Y} : {Z}";
    }
}