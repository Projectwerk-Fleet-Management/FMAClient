using BusinessLayer.Exceptions;

namespace BusinessLayer.Validators
{
    public class FuelcardNumberValidator
    {
        private int _FuelcardNumberLength = 18;
        public bool isValid(string cardnumber)
        {
            string allowedLetters = "1234567890.- ";
            string tocheck = "";
            if (string.IsNullOrWhiteSpace(cardnumber)) throw new FuelcardNumberValidatorException("FuelcardNumberValidator - Fuel card number is empty");
            foreach (char c in cardnumber)
            {
                if (c != '.' && c != '-' && c != ' ')
                {
                    tocheck = tocheck + c;
                }
            }
            foreach (char c in cardnumber)
            {
                if (!allowedLetters.Contains(c))
                {
                    throw new FuelcardNumberValidatorException("FuelcardNumberValidator - Fuel card number contains an invalid character (@/_/a/...)");
                }
            }
            if (tocheck.Length != _FuelcardNumberLength) throw new FuelcardNumberValidatorException($"FuelcardNumberValidator - Fuel card number length isn't equal to {_FuelcardNumberLength}");
            return true;
        }
    }
}