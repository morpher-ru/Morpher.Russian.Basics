using System.Collections.Generic;
using System.Linq;

namespace Morpher.Russian
{
    public static class Syllable
    {
        public static bool IsMultisyllable (this string lowercaseRussianWord)
        {
            return lowercaseRussianWord.IndexOfAny (Vowels.LowercaseArray) 
                != lowercaseRussianWord.LastIndexOfAny (Vowels.LowercaseArray);
        }

        public static int GetSyllableCount (this IEnumerable<char> lowercaseRussianWord)
        {
            return lowercaseRussianWord.Count (Vowels.LowercaseString.Contains);
        }
    }
}