using NUnit.Framework;

namespace Morpher.Russian
{
    [TestFixture]
    public class ConvertStressMarkToUpperCaseTests
    {
        [Test]
        [TestCase("кОшка")]
        [TestCase("Оси")]
        [TestCase("кот")]
        [TestCase("мёд")]
        [TestCase("львОм николАевичем толстЫм")]
        public static void Test (string s)
        {
            var stressMark = Stress.ConvertUpperCaseToStressMark (s);

            var upperCase = Stress.ConvertStressMarkToUpperCase (stressMark);

            Assert.AreEqual (s, upperCase);
        }
    }
}