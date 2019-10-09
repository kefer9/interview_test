namespace RepeatedStringSolution.Chain
{
    public class MultipleOfThree : FizzBuzzChainBase
    {
        public MultipleOfThree(FizzBuzzChainBase successor) : base(successor)
        {
        }

        protected override string Message { get; set; } = "Fizz";
        protected override bool Match(int value)
        {
            return value % 3 == 0;
        }
    }
}
