namespace RepeatedStringSolution.Chain
{
    public abstract class FizzBuzzChainBase
    {
        private readonly FizzBuzzChainBase _successor;

        protected FizzBuzzChainBase(FizzBuzzChainBase successor)
        {
            _successor = successor;
        }
        
        protected abstract string Message { get; set; }
        protected abstract bool Match(int value);
        public string DisplayMessage(int value)
        {
            return Match(value) ? Message : _successor.DisplayMessage(value);
        }
    }
}
