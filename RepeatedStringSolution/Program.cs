using System;
using RepeatedStringSolution.Factory;

namespace RepeatedStringSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string to repeat:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Input the number of character to consider:");
            int numberOfCharacterToConsider = Convert.ToInt32(Console.ReadLine());

            var factory = new CountingAlgorithmFactory();
            var strategy = factory.CreateAStrategy(numberOfCharacterToConsider);
            var numberOfA = strategy.CountOccurrences(inputString, numberOfCharacterToConsider);
            var fizzBuzz = new FizzBuzzChainFactory().Create();
            Console.WriteLine(fizzBuzz.DisplayMessage(numberOfA));
        }
    }
}
