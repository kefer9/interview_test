using System;
using Microsoft.Extensions.DependencyInjection;
using RepeatedStringSolution.Factory;
using RepeatedStringSolution.Processor;

namespace RepeatedStringSolution
{
    class Program
    {
        private static IServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            //Setting up DI
            RegisterServices();

            Console.WriteLine("Input a string to repeat:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Input the number of character to consider:");
            int numberOfCharacterToConsider = Convert.ToInt32(Console.ReadLine());
            
            var processor = _serviceProvider.GetService<IFizzBuzzProcessor>();
            Console.WriteLine(processor.Process(inputString,numberOfCharacterToConsider));

            DisposeServices();
        }

        private static void RegisterServices()
        {
            var collection = new ServiceCollection();
            collection.AddScoped<ICountingAlgorithmFactory, CountingAlgorithmFactory>();
            collection.AddScoped<IFizzBuzzChainFactory, FizzBuzzChainFactory>();
            collection.AddScoped<IFizzBuzzProcessor, FizzBuzzProcessor>();
            _serviceProvider = collection.BuildServiceProvider();
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
