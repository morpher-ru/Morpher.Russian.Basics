using System.Linq;
using NUnit.Framework;

namespace Morpher.Russian
{
    [TestFixture]
    public class AlphabetTests
    {
        [Test]
        public void RussianAlphabetHas33Letters()
        {
            Assert.AreEqual (33, Alphabet.LowercaseString.Length);
            Assert.AreEqual (33, Alphabet.UppercaseString.Length);
        }

        [Test]
        public void AlphabetHasAllVowels()
        {
            Assert.IsTrue (Vowels.LowercaseArray.All (Alphabet.LowercaseString.Contains));
            Assert.IsTrue (Vowels.UppercaseArray.All (Alphabet.UppercaseString.Contains));
        }
    }
}
