using System;
using BusinessLayer.Validators;

namespace FMA_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            NINValidator x = new NINValidator();
            bool test = x.isValid("93.11.23-283.87");

        }
    }
}
