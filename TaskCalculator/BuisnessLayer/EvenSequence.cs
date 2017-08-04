using System.Collections.Generic;
using TaskCalculator.Interfaces;

namespace TaskCalculator.BuisnessLayer
{
    public class EvenSequence : ICalculateSequence
    {
        public string Calculate(int number)
        {
            var sequence = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0 || i == number)
                    sequence.Add(i);
            }
            return string.Join(" ", sequence);
        }

    }
}