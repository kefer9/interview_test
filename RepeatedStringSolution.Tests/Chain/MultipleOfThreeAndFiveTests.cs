using NUnit.Framework;
using RepeatedStringSolution.Chain;

namespace RepeatedStringSolution.Tests.Chain
{
    public class MultipleOfThreeAndFiveTests
    {
        private MultipleOfThreeAndFive _chain;

        [OneTimeSetUp]
        public void SetUp()
        {
            _chain = new MultipleOfThreeAndFive(null);
        }

        [TestCase(0, "FizzBuzz")]
        [TestCase(3, "3")]
        [TestCase(5, "5")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(99, "99")]
        [TestCase(100, "100")]
        public void DisplayMessage_ReturnsExpectedResult(int value, string expectedResult)
        {
            var result = _chain.DisplayMessage(value);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
