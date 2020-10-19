using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

// salt ...

namespace T3
{
    internal sealed class Old : IDisposable
    {
        private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose()
        {
            _safeHandle?.Dispose();
            _safeHandle = null;
        }
    }

    public sealed class OldEx
    {
        public void Ex()
        {
            using (var oldObj = new Old())
            {
                throw new Exception();
                // ...
            }
        }
    }

    internal sealed class New : IAsyncDisposable
    {
        // https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-disposeasync
        public async ValueTask DisposeAsync()
        {
            // await ...
        }
    }

    public sealed class NewEx
    {
        public async ValueTask Ex()
        {
            await using (var newObj = new New())
            {
                throw new Exception();
                // ...
            }
        }
    }
}