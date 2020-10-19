using System;

namespace Ex
{
    ref struct OldRStr
    {
        // ...
    }

    readonly ref struct OldRRStr
    {
        // ...
    }

    internal sealed class OldEx
    {
        internal void Ex()
        {
            // using (var rstr = new OldRStr())
            // {
            //     // ...
            // }
            //
            // using (var rrstr = new OldRRStr())
            // {
            //     // ...
            // }
        }
    }

    ref struct NewRStr
    {
        public void Dispose()
        {
            // ...
        }
    }

    readonly ref struct NewRRStr
    {
        public void Dispose()
        {
            // ...
        }
    }

    internal sealed class NewEx
    {
        internal void Ex()
        {
            using (var rstr = new NewRStr())
            {
                // ...
            }

            using (var rrstr = new NewRRStr())
            {
                // ...
            }
        }
    }
}