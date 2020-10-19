using System;

namespace Ex
{
    enum Flag
    {
        White,
        Red,
        WhiteAgain
    }

    enum Quadrant
    {
        Origin,
        One,
        Two,
        Three,
        Four,
        OnBorder
    }

    readonly ref struct RgbColor
    {
        public RgbColor(double r, double g, double b) => (R, G, B) = (r, g, b);

        public double R { get; }
        public double G { get; }
        public double B { get; }
    }

    readonly ref struct Point
    {
        public Point(int x, int y) => (X, Y) = (x, y);

        public int X { get; }
        public int Y { get; }

        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }

    internal sealed class MyClass
    {
        internal void SwitchExpressionsEx()
        {
            static RgbColor ToRgbOld(Flag color)
            {
                switch (color)
                {
                    case Flag.White:
                        return new RgbColor(0xFF, 0xFF, 0xFF);
                    case Flag.Red:
                        return new RgbColor(0xFF, 0x00, 0x00);
                    case Flag.WhiteAgain:
                        return new RgbColor(0xFF, 0xFF, 0xFF);
                    default:
                        throw new ArgumentException("invalid enum value", nameof(color));
                }
            }

            static RgbColor ToRgbNew(Flag color) => color switch
            {
                Flag.White => new RgbColor(0xFF, 0xFF, 0xFF),
                Flag.Red => new RgbColor(0xFF, 0x00, 0x00),
                Flag.WhiteAgain => new RgbColor(0xFF, 0xFF, 0xFF),

                _ => throw new ArgumentException("invalid enum value", nameof(color))
            };
        }

        internal void PropertyPatterns()
        {
            static double Action(in RgbColor color) => color switch
            {
                {R: 0xFF, B: 0x00} => 255d,
                {R: 0xFF} => 255d,

                _ => 0d
            };
        }

        internal void TuplePatterns()
        {
            static double Action(in RgbColor color) => (color.R, color.B) switch
            {
                (0xFF, 0x00) => 255d,
                (0xFF, _) => 255d,

                (_, _) => 0d // _ => 0d
            };
            
            
            static double Action1(in RgbColor color) => new System.Tuple<double, double>(color.R, color.B) switch
            {
                (0xFF, 0x00) => 255d,
                (0xFF, _) => 255d,

                (_, _) => 0d // _ => 0d
            };
        }

        internal void PositionalPatterns()
        {
            static Quadrant GetQuadrant(Point point) => point switch
            {
                (0, 0) => Quadrant.Origin,

                var (x, y) when x > 0 && y > 0 => Quadrant.One,
                var (x, y) when x < 0 && y > 0 => Quadrant.Two,
                var (x, y) when x < 0 && y < 0 => Quadrant.Three,
                var (x, y) when x > 0 && y < 0 => Quadrant.Four,

                var (_, _) => Quadrant.OnBorder,
            };
        }
    }
}