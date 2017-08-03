using System;
using TaskCalculator.Interfaces;

namespace TaskCalculator.BuisnessLayer
{
    public class ValidateNumber : IValidateNumber
    {
        public bool ValidateInputNumber(double? input)
        {
            if (input < 0 || input % 1 != 0 || input == null)
                return false;
            else
                return true;
        }
    }
}