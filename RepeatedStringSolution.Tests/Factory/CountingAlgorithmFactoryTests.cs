using System;
using NUnit.Framework;
using RepeatedStringSolution.Factory;
using RepeatedStringSolution.Strategy;

namespace RepeatedStringSolution.Tests.Factory
{
    public class CountingAlgorithmFactoryTests
    {
        private ICountingAlgorithmFactory _factory;

        [OneTimeSetUp]
        public void SetUp()
        {
            _factory = new CountingAlgorithmFactory();
        }

        [TestCase(1,typeof(SlowStrategy))]
        [TestCase(10000000, typeof(FastStrategy))]
        public void GivenStringLegth_CreateAStrategy_ReturnsCorrectStrategy(int stringLength, Type expectedStrategyType)
        {
            var result = _factory.CreateAStrategy(stringLength);
            Assert.AreEqual(expectedStrategyType,result.GetType());
        }
    }
}
