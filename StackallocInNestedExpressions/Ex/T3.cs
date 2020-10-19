using System;

namespace Ex
{
    internal sealed class MyClass
    {
        internal void Ex()
        {
            Span<int> numbers = stackalloc[] { 1, 2, 3, 4, 5, 6 }; // or ReadOnlySpan<int>
            
            numbers.IndexOfAny(stackalloc[] { 4, 6, 8 }); // 3

            Ex2(numbers);
            
            // ...
        }


        internal void Ex2(in Span<int> abc)
        {
            // ...
        }
    }
}