using System;

namespace Ex
{
    internal sealed class MyClass
    {
        internal void Ex()
        {
            /*
             * In C# 7.3 and earlier, a constructed type (a type that includes at least one type argument)
             * can't be an unmanaged type.
             * 
             * Starting with C# 8.0, a constructed value type is unmanaged if it contains fields of unmanaged types only.
             */

            Span<Coords<int>> coordinates = new Span<Coords<int>>();
        }
    }

    readonly struct Coords<T>
    {
        public Coords(T x, T y) => (X, Y) = (x, y);

        public T X { get; }
        public T Y { get; }
    }
}