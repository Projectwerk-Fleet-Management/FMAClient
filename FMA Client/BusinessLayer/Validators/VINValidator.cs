using System;
using BusinessLayer.Exceptions;
using System.Collections.Generic;

namespace BusinessLayer.Validators
{
    public class VINValidator
    {
        private int _VINLength = 17; // VIN have a length of 17 (used to be 11 before 1981 but that's not the case anymore)
        private int sum = 0;
        private int checkDigit;

        public bool IsValid(string vin)
        {
            vin.ToLower();
            if (vin == null) throw new VINValidatorException("VINValidator - VIN is empty");
            if (vin.Length != _VINLength) throw new VINValidatorException($"VINValidator - VIN length isn't equal to {_VINLength}");
            if (vin.Contains("i") || vin.Contains("o") || vin.Contains("q")) throw new VINValidatorException("VINValidator - VIN contains an invalid character (I/O/Q)");
            
            Dictionary<char, int> charReplacerList = new Dictionary<char, int>();

            #region hashtable insertion
            charReplacerList.Add('A', 1);
            charReplacerList.Add('B', 2);
            charReplacerList.Add('C', 3);
            charReplacerList.Add('D', 4);
            charReplacerList.Add('E', 5);
            charReplacerList.Add('F', 6);
            charReplacerList.Add('G', 7);
            charReplacerList.Add('H', 8);
            charReplacerList.Add('J', 1);
            charReplacerList.Add('K', 2);
            charReplacerList.Add('L', 3);
            charReplacerList.Add('M', 4);
            charReplacerList.Add('N', 5);
            charReplacerList.Add('P', 7);
            charReplacerList.Add('R', 9);
            charReplacerList.Add('S', 2);
            charReplacerList.Add('T', 3);
            charReplacerList.Add('U', 4);
            charReplacerList.Add('V', 5);
            charReplacerList.Add('W', 6);
            charReplacerList.Add('X', 7);
            charReplacerList.Add('Y', 8);
            charReplacerList.Add('Z', 9);
            charReplacerList.Add('1', 1);
            charReplacerList.Add('2', 2);
            charReplacerList.Add('3', 3);
            charReplacerList.Add('4', 4);
            charReplacerList.Add('5', 5);
            charReplacerList.Add('6', 6);
            charReplacerList.Add('7', 7);
            charReplacerList.Add('8', 8);
            charReplacerList.Add('9', 9);
            charReplacerList.Add('0', 0);
            #endregion


            for (int i = 0; i < vin.Length; i++)
            {
                if (i == 8)
                {
                    checkDigit = vin[i];
                    continue;
                }

                int sum =+ charReplacerList[vin[i]];
            }

            foreach (char c in vin)
            {
                int sum = +charReplacerList[c];
            }

            if (sum % 11 != checkDigit)
            {
                return false;
            }

            return true;
        }
    }
}
