using System;

namespace Ex
{
    internal sealed class MyClass
    {
        internal int ExOld()
        {
            int y;
            LocalFunction();
            return y;

            void LocalFunction() => y = 0;
        }
        
        internal int ExNew()
        {
            LocalStaticFunction(out var y);
            return y;

            static void LocalStaticFunction(out int y) => y = 0;
        }
    }
}