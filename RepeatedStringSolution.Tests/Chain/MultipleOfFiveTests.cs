using NUnit.Framework;
using RepeatedStringSolution.Chain;

namespace RepeatedStringSolution.Tests.Chain
{
    public class MultipleOfFiveTests
    {
        private MultipleOfFive _chain;
        
        [OneTimeSetUp]
        public void SetUp()
        {
            _chain = new MultipleOfFive(null);
        }

        [TestCase(0, "Buzz")]
        [TestCase(3, "3")]
        [TestCase(5,"Buzz")]
        [TestCase(15, "Buzz")]
        [TestCase(99, "99")]
        [TestCase(100, "Buzz")]
        public void DisplayMessage_ReturnsExpectedResult(int value, string expectedResult)
        {
            var result = _chain.DisplayMessage(value);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
