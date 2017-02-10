using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Morpher.Russian
{
    [TestFixture]
    public abstract class SyllableTests
    {
        protected static Dictionary<string, int> TestCases = new Dictionary<string, int>
        {
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

        protected abstract void Func(string value);

        [Test]
        public void EmptyString()
        {
            Assert.Catch<ArgumentException>(() => Func(""));
        }

        [Test]
        public void NullString()
        {
            Assert.Catch<ArgumentException>(() => Func(null));
        }

        [TestFixture]
        public class IsMultisyllableTests : SyllableTests
        {
            [Test, TestCaseSource(nameof(TestCases))]
            public void Test(KeyValuePair<string, int> testCase)
            {
                Assert.AreEqual(testCase.Value > 1, Syllable.IsMultisyllable(testCase.Key));
            }

            protected override void Func(string value)
            {
                Syllable.IsMultisyllable(value);
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

            protected override void Func(string value)
            {
                Syllable.GetSyllableCount(value);
            }
        }
    }
}
