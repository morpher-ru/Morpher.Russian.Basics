using System.Text.RegularExpressions;

namespace Morpher.Russian
{
    public static class Stress
    {
        public const string PrimaryStressMark = "\u0301";
        public const string SecondaryStressMark = "\u0300";

        public static string StripStressMarksAndYo (this string s) => 
            s.StripStressMarks().StripYo();

        public static string StripYo (this string s) => s
            .Replace('ё', 'е')
            .Replace('Ё', 'Е');

        public static string StripStressMarks (this string s) => 
            s.Replace (PrimaryStressMark, "");

        public static string ConvertUpperCaseToStressMark (string s) =>
            Regex.Replace (s, $"([{Vowels.UppercaseString}])", 
                match => match.Groups [0].Value.ToLowerInvariant () + PrimaryStressMark);

        public static string ConvertStressMarkToUpperCase (string s) =>
            Regex.Replace (s, $"([{Vowels.LowercaseString}]){PrimaryStressMark}", 
                match => match.Groups [1].Value.ToUpperInvariant ());
    }
}