using NUnit.Framework;
using RepeatedStringSolution.Chain;
using RepeatedStringSolution.Factory;

namespace RepeatedStringSolution.Tests.Factory
{
    public class FizzBuzzChainFactoryTests
    {
        private IFizzBuzzChainFactory _factory;

        [OneTimeSetUp]
        public void Setup()
        {
            _factory = new FizzBuzzChainFactory();
        }

        [Test]
        public void CallingCreate_ReturnsExpectedBaseType()
        {
            var result = _factory.Create();
            Assert.AreEqual(typeof(FizzBuzzChainBase),result.GetType().BaseType);
        }

        [TestCase(0, "FizzBuzz")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(99, "Fizz")]
        [TestCase(100, "Buzz")]
        [TestCase(101, "101")]
        public void DisplayMessage_ReturnsExpectedResult(int value, string expectedResult)
        {
            var result = _factory.Create().DisplayMessage(value);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
