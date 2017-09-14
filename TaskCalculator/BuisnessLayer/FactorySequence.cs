using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskCalculator.Interfaces;

namespace TaskCalculator.BuisnessLayer
{
    public static class FactorySequence
    {
        public static ICalculateSequence GetSequence (string type)
        {
            switch (type)
            {
                case "odd":
                    return new OddSequence();                    
                case "even":
                    return new EvenSequence();
                case "zce":
                    return new ZCESequence();                    
                case "fibonacci":
                   return new FibonacciSequence();
                default:
                    return new Sequence();
            }
        }
    }
}