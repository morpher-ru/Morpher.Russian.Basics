namespace Morpher.Russian
{
    public static class Alphabet
    {
        public const string LowercaseString = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public const string UppercaseString = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public static readonly char[] LowercaseArray = LowercaseString.ToCharArray();
        public static readonly char[] UppercaseArray = UppercaseString.ToCharArray();
    }
}