using RepeatedStringSolution.Strategy;

namespace RepeatedStringSolution.Factory
{
    public interface ICountingAlgorithmFactory
    {
        ICountLetterAStrategy CreateAStrategy(int stringLength);
    }
}
