using System.Collections.Generic;

namespace TaskCalculator.BuisnessLayer
{
    public class ZSequence: Sequence
    {
        public override string Calculate(int number)
        {
            var sequence = new List<int>();
            if (number % 5 == 0 && number % 3 == 0)
            {
                return "Z";
            }
            return base.Calculate(number); ;
        }        
    }
}