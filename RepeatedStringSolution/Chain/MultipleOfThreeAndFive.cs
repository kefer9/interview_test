using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatedStringSolution.Chain
{
    public class MultipleOfThreeAndFive : FizzBuzzChainBase
    {
        public MultipleOfThreeAndFive(FizzBuzzChainBase successor) : base(successor)
        {
        }

        protected override string Message { get; set; } = "FizzBuzz";

        protected override bool Match(int value)
        {
            return value % 3 == 0 && value % 5 == 0;
        }
    }
}
