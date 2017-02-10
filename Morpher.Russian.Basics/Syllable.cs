using System;
using System.Collections.Generic;
using System.Linq;

namespace Morpher.Russian
{
    public static class Syllable
    {
        public static bool IsMultisyllable (string lowercaseRussianWord)
        {
            return lowercaseRussianWord.IndexOfAny (Vowels.LowercaseArray) 
                != lowercaseRussianWord.LastIndexOfAny (Vowels.LowercaseArray);
        }

        public static int GetSyllableCount (IEnumerable<char> lowercaseRussianWord)
        {
            return lowercaseRussianWord.Count (Vowels.LowercaseString.Contains);
        }
    }
}