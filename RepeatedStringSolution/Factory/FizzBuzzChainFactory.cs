using RepeatedStringSolution.Chain;

namespace RepeatedStringSolution.Factory
{
    public class FizzBuzzChainFactory : IFizzBuzzChainFactory
    {
        public FizzBuzzChainBase Create()
        {
            return new MultipleOfThreeAndFive(new MultipleOfFive(new MultipleOfThree(new NoMatch())));
        }
    }
}
