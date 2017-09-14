using System.Collections.Generic;

namespace TaskCalculator.BuisnessLayer
{
    public class ZCESequence: Sequence
    {
        public override string Calculate(int number)
        {
            var sequence = new List<int>();
            if (number % 5 == 0 && number % 3 == 0)
            {
                return "Z";
            }            
            if (number % 3 == 0)
            {
                return "C";
            }
            if (number % 5 == 0)
            {
                return "E";
            }
            return base.Calculate(number); ;
        }        
    }
}