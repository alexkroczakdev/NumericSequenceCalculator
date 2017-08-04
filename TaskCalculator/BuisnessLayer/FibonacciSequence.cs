using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskCalculator.Interfaces;

namespace TaskCalculator.BuisnessLayer
{
    public class FibonacciSequence : ICalculateSequence
    {
        public string Calculate(int number)
        {
            var sequence = new List<int>();
            sequence.Add(1);
            sequence.Add(1);
            for (int i = sequence.Last(), j = 1 ; i < number; i = sequence.Last(), j++)
            {
                sequence.Add(sequence[j-1] + i);
            }

            if (sequence.Last() != number)
            {
                sequence.Remove(sequence.Last());
                sequence.Add(number);
            }

            return string.Join(" ", sequence);
        }
    }
}