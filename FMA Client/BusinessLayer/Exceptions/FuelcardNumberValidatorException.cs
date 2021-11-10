using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Exceptions
{
    public class FuelcardNumberValidatorException : Exception
    {
        public FuelcardNumberValidatorException()
        {
        }

        public FuelcardNumberValidatorException(string message) : base(message)
        {
        }
    }
}
