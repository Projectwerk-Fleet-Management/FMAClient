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
            //NINValidator x = new NINValidator();
            //bool test = x.isValid("93.11.23-283.87");

            //Driver t = new Driver("-5", "Batselier", "Bryan", new DateTime(1993, 11, 23), "93.11.23-283.85", new List<LicenseType> { LicenseType.A, LicenseType.BE });

            VINValidator x = new VINValidator();

            //First four give errors back, fifth gives false back and last two give true back
            //Console.WriteLine(x.IsValid(null));
            //Console.WriteLine(x.IsValid("1M8GDM9AKP042788"));
            //Console.WriteLine(x.IsValid("1M8GDM9AQKP042788"));
            //Console.WriteLine(x.IsValid("1M8GDM9A_KP042788"));
            //Console.WriteLine(x.IsValid("1M8GDM9A_KP042798"));
            //Console.WriteLine(x.IsValid("1M8GDM9AXKP042788"));
            //Console.WriteLine(x.IsValid("WAUZZZ8V5KA106598"));
        }
    }
}
