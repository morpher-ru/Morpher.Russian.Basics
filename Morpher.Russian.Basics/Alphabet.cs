namespace Morpher.Russian
{
    public static class Alphabet
    {
        public const string LowercaseString = "àáâãäå¸æçèéêëìíîïğñòóôõö÷øùúûüışÿ";
        public const string UppercaseString = "ÀÁÂÃÄÅ¨ÆÇÈÉÊËÌÍÎÏĞÑÒÓÔÕÖ×ØÙÚÛÜİŞß";
        public static readonly char[] LowercaseArray = LowercaseString.ToCharArray();
        public static readonly char[] UppercaseArray = UppercaseString.ToCharArray();
    }
}