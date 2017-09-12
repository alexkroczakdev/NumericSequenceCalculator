using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCalculator.Interfaces
{
    public interface IValidateNumber
    {
        bool ValidateInputNumber(UInt32 input);
    }
}
