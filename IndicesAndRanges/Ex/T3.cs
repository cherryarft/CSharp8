using System;

namespace Ex
{
    internal sealed class MyClass
    {
        internal void Ex()
        {
            // System.Index => ^
            // System.Range => ..

            var words = new string[]
            {
                "The",
                "quick",
                "brown",
                "fox",
                "jumped",
                "over",
                "the",
                "lazy",
                "dog"
            };

            // words[^0] == words[words.Length]
            // words[0] == words[^words.Length]

            var dog = words[^1];
            
            var quickBrownFox = words[1..4]; // words[1..4..6];
            
            var allWords = words[..];
            
            var lazyDog = words[^2..^0]; //  words[^2..];
            
            var phrase = 1..4;
            quickBrownFox = words[phrase];
        }
    }
}