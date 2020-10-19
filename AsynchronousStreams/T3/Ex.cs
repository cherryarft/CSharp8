using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// sugar

namespace T3
{
    internal sealed class OldEx
    {
        IEnumerable<int> GenerateSequence()
        {
            var rm = new Random();
            for (var i = 0; i < 20; ++i) yield return rm.Next(i);
        }

        internal void Ex()
        {
            foreach (var i in GenerateSequence())
            {
                // ...
            }
        }
    }

    internal sealed class NewEx
    {
        async IAsyncEnumerable<int> GenerateSequenceAsync()
        {
            var rm = new Random();
            for (var i = 0; i < 20; ++i)
            {
                // violent activity
                await Task.Delay(100);

                yield return rm.Next(i);
            }
        }

        internal async ValueTask Ex()
        {
            await foreach (var i in GenerateSequenceAsync())
            {
                // ...
            }
        }
    }
}