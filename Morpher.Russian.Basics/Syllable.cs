using System;
using System.Linq;

namespace Morpher.Russian
{
    public static class Syllable
    {
        public static bool IsMultisyllable (string lowercaseRussianWord)
        {
            NotNullOrEmpty(lowercaseRussianWord);

            return lowercaseRussianWord.IndexOfAny (Vowels.LowercaseArray) 
                != lowercaseRussianWord.LastIndexOfAny (Vowels.LowercaseArray);
        }

        public static int GetSyllableCount (string lowercaseRussianWord)
        {
            NotNullOrEmpty(lowercaseRussianWord);

            return lowercaseRussianWord.Count (Vowels.LowercaseString.Contains);
        }

        private static void NotNullOrEmpty(string lowercaseRussianWord)
        {
            if (string.IsNullOrEmpty(lowercaseRussianWord))
                throw new ArgumentException("Input string should not be null or empty.", nameof(lowercaseRussianWord));
        }
    }
}