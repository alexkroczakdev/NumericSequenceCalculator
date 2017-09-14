using System.Collections.Generic;
using TaskCalculator.Interfaces;

namespace TaskCalculator.BuisnessLayer
{
    public class Sequence: ICalculateSequence
    {
        public virtual string Calculate(int number)
        {
            var sequence = new List<int>();
            for(int i = 1; i <= number; i++)
            {
                sequence.Add(i);
            }
            return string.Join(" ",sequence);           
        }
    }
}