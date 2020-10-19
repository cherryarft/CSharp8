namespace Ex
{
    internal sealed class MyClass
    {
        internal void Ex()
        {
            object a = null;
            
            // ...

            var b = a ?? string.Empty; // if(a is not null) { a } else { string.Empty }; 
            
            // ...

            b ??= a; // if (b is null) b = a;
        }
    }
}