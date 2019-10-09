using NUnit.Framework;
using RepeatedStringSolution.Strategy;

namespace RepeatedStringSolution.Tests.Strategy
{
    public class SlowStrategyTests
    {
        private ICountLetterAStrategy _strategy;
        
        [OneTimeSetUp]
        public void Setup()
        {
            _strategy = new SlowStrategy();
        }

        [TestCase("ababa", 5, 3)]
        [TestCase("ababa", 10, 6)]
        [TestCase("ababa", 11, 7)]
        [TestCase("ababa", 12, 7)]
        [TestCase("ababa", 100, 60)]
        [TestCase("ababa", 100000, 60000)]
        [TestCase("ababa", 0, 0)]
        [TestCase("ababa", -100, 0)]
        [TestCase(null, -100, 0)]
        // With the slow strategy the following test will likely crash your machine ;)
        //[TestCase("bbabb", int.MaxValue, int.MaxValue / 5)]
        public void CountOccurrencesShouldReturnExpectedResult(string inputString, int stringLength, int expectedResult)
        {
            var result = _strategy.CountOccurrences(inputString, stringLength);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
