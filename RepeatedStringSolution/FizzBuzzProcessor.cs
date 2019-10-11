using System;
using System.Collections.Generic;
using System.Text;
using RepeatedStringSolution.Factory;
using RepeatedStringSolution.Processor;

namespace RepeatedStringSolution
{
    public class FizzBuzzProcessor : IFizzBuzzProcessor
    {
        private ICountingAlgorithmFactory _countingAlgorithmFactory;
        private IFizzBuzzChainFactory _fizzBuzzChainFactory;

        public FizzBuzzProcessor(ICountingAlgorithmFactory countingAlgorithmFactory,
            IFizzBuzzChainFactory fizzBuzzChainFactory)
        {
            _countingAlgorithmFactory = countingAlgorithmFactory;
            _fizzBuzzChainFactory = fizzBuzzChainFactory;
        }
        public string Process(string inputString, int numberOfLetterToAnalyse)
        {
            var strategy = _countingAlgorithmFactory.CreateAStrategy(numberOfLetterToAnalyse);
            var numberOfA = strategy.CountOccurrences(inputString, numberOfLetterToAnalyse);
            var fizzBuzz = _fizzBuzzChainFactory.Create();
            return fizzBuzz.DisplayMessage(numberOfA);
        }
    }
}
