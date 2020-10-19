using System;
using System.IO;

namespace Ex
{
    internal sealed class MyClass
    {
        internal void ExOld()
        {
            using (var reader = new StreamReader(":)"))
            {
                var data = reader.ReadToEnd();
                using (var writer = new StreamWriter("(:"))
                using (var memory = new MemoryStream())
                {
                    memory.Write(stackalloc[] {byte.Parse(data)});
                }
            }
        }

        internal void ExNew()
        {
            using var reader = new StreamReader(":)");
            using var writer = new StreamWriter("(:");
            using var memory = new MemoryStream();

            var data = reader.ReadToEnd();
            writer.Write(data);
            memory.Write(stackalloc[] {byte.Parse(data)});
        }
    }
}