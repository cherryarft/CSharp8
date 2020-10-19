using System;

namespace Ex
{
    /*
     * * You can now add members to interfaces and provide an implementation for those members.
     * 
     * * This language feature enables API authors to add methods to an interface
     * * in later versions without breaking source or binary compatibility with
     * * existing implementations of that interface.
     *
     * * Default interface methods also enable scenarios similar to a "traits" language feature.
     * 
     * * This feature also enables C# to interoperate with APIs that target Android or Swift, which support similar features.
     *
     */

    interface IMyInterface
    {
        void MyAction()
        {
            // ...
        }
    }

    internal sealed class MyClass : IMyInterface
    {
        internal void Ex() => ((IMyInterface) this).MyAction();
    }
}