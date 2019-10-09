using NUnit.Framework;
using RepeatedStringSolution.Strategy;

namespace RepeatedStringSolution.Tests.Strategy
{
    public class FastStrategyTests
    {
        private ICountLetterAStrategy _strategy;
        
        [OneTimeSetUp]
        public void Setup()
        {
            _strategy = new FastStrategy();
        }

        [TestCase("ababa", 5, 3)]
        [TestCase("ababa", 10, 6)]
        [TestCase("ababa", 12, 7)]
        [TestCase("ababa", 100, 60)]
        [TestCase("ababa", 100000, 60000)]
        [TestCase("bbabb", int.MaxValue, int.MaxValue / 5)]
        [TestCase("ababa", 0, 0)]
        [TestCase("ababa", -100, 0)]
        [TestCase(null, -100, 0)]
        public void CountOccurrencesShouldReturnExpectedResult(string inputString, int stringLength, int expectedResult)
        {
            var result = _strategy.CountOccurrences(inputString, stringLength);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
