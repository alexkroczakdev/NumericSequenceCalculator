using System;
using TaskCalculator.Interfaces;

namespace TaskCalculator.BuisnessLayer
{
    public class ValidateNumber : IValidateNumber
    {
        public bool ValidateInputNumber(UInt32 input)
        {
            if (input == 0)
                return false;
            else
                return true;
        }
    }
}