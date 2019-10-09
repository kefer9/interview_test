using RepeatedStringSolution.Strategy;

namespace RepeatedStringSolution.Factory
{
    public class CountingAlgorithmFactory : ICountingAlgorithmFactory
    {
        public ICountLetterAStrategy CreateAStrategy(int stringLength)
        {
            if (stringLength > 100000)
            {
                return new FastStrategy();
            }

            return new SlowStrategy();
        }
    }
}
