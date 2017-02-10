using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Morpher.Russian
{
    public abstract class SyllableTests
    {
        protected static Dictionary<string, int> TestCases = new Dictionary<string, int>
        {
            { "", 0 },
            { "а", 1 },
            { "б", 0 },
            { "аб", 1 },
            { "ба", 1 },
            { "аба", 2 },
            { "абаб", 2 },
            { "баба", 2 },
            { "бабба", 2 },
            { "баббаб", 2 },
            { "бб", 0 },
            { "ббб", 0 },
            { "ббба", 1 },
            { "баобаб", 3 },
        };

        [TestFixture]
        public class IsMultisyllableTests : SyllableTests
        {
            [Test, TestCaseSource(nameof(TestCases))]
            public void Test(KeyValuePair<string, int> testCase)
            {
                Assert.AreEqual(testCase.Value > 1, Syllable.IsMultisyllable(testCase.Key));
            }

            [Test]
            public void NullString()
            {
                Assert.Catch<NullReferenceException>(() => Syllable.IsMultisyllable(null));
            }
        }

        [TestFixture]
        public class GetSyllableCountTest : SyllableTests
        {
            [Test, TestCaseSource(nameof(TestCases))]
            public void Test(KeyValuePair<string, int> testCase)
            {
                Assert.AreEqual(testCase.Value, Syllable.GetSyllableCount(testCase.Key));
            }

            [Test]
            public void NullString()
            {
                Assert.Catch<ArgumentException>(() => Syllable.GetSyllableCount(null));
            }
        }
    }
}
