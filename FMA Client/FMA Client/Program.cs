using System;
using BusinessLayer.Validators;
using BusinessLayer;
using BusinessLayer.Model;
using System.Collections.Generic;

namespace FMA_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            NINValidator x = new NINValidator();
            bool test = x.isValid("93.11.23-283.87");

            Driver t = new Driver("-5", "Batselier", "Bryan", new DateTime(1993, 11, 23), "93.11.23-283.85", new List<LicenseType> { LicenseType.A, LicenseType.BE });
        }
    }
}
