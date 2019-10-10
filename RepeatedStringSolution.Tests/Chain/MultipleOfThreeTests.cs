using NUnit.Framework;
using RepeatedStringSolution.Chain;

namespace RepeatedStringSolution.Tests.Chain
{
    public class MultipleOfThreeTests
    {
        private MultipleOfThree _chain;

        [OneTimeSetUp]
        public void SetUp()
        {
            _chain = new MultipleOfThree(null);
        }

        [TestCase(0, "Fizz")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "5")]
        [TestCase(15, "Fizz")]
        [TestCase(99, "Fizz")]
        [TestCase(100, "100")]
        public void DisplayMessage_ReturnsExpectedResult(int value, string expectedResult)
        {
            var result = _chain.DisplayMessage(value);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
