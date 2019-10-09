namespace RepeatedStringSolution.Chain
{
    public class NoMatch : FizzBuzzChainBase
    {
        public NoMatch() : base(null)
        {

        }

        protected override string Message { get; set; } 
        protected override bool Match(int value)
        {
            Message = value.ToString();
            return true;
        }
    }
}
