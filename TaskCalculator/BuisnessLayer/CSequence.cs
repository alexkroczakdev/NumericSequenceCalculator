using System.Collections.Generic;

namespace TaskCalculator.BuisnessLayer
{
    public class CSequence: Sequence
    {
        public override string Calculate(int number)
        {
            var sequence = new List<int>();
            if (number % 3 == 0)
            {
                return "C";
            }
            return base.Calculate(number);
        }
    }
}