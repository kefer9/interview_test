using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatedStringSolution.Chain
{
    public class MultipleOfFive : FizzBuzzChainBase
    {
        public MultipleOfFive(FizzBuzzChainBase successor) : base(successor)
        {
        }

        protected override string Message { get; set; } = "Buzz";
        protected override bool Match(int value)
        {
            return value % 5 == 0;
        }
    }
}
