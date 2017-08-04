using System.Collections.Generic;

namespace TaskCalculator.BuisnessLayer
{
    public class ESequence: Sequence
    {
        public override string Calculate(int number)
        {
            var sequence = new List<int>();
            if (number % 5 == 0)
            {
                return "E";
            }
            return base.Calculate(number);
        }
    }
}