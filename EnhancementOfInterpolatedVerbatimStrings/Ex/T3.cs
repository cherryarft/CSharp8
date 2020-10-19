using System;

namespace Ex
{
    internal sealed class MyClass
    {
        internal void Ex()
        {
            var path0 = $@"{0}";
            var path1 = @$"{1}";
            
            Console.WriteLine(path0);
            Console.WriteLine(path1);
        }
    }
}