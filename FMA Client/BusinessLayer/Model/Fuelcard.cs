using System;
using System.Collections.Generic;
using BusinessLayer.Exceptions;
using BusinessLayer.Validators;

namespace BusinessLayer
{
    public class Fuelcard
    {
        public string Cardnumber { private set; get; }
        public DateTime ExpiryDate { private set; get; }
        public string Pincode { private set; get; }
        public List<Fuel> FueltypeList { private set; get; }
        public Driver Driver { private set; get; }
        public bool isActive { private set; get; }

        private FuelcardNumberValidator validator = new FuelcardNumberValidator();

        public Fuelcard(string cardnumber, DateTime expiryDate)
        {
            if (cardnumber == null)
            {
                throw new FuelcardException("Cardnumber cannot be null");
            }

            if (!validator.isValid(cardnumber))
            {
                throw new FuelcardException("The entered fuelcardnumber is not valid");
            }
            if (expiryDate < DateTime.Now)
            {
                throw new FuelcardException("This card is already expired");
            }
            Cardnumber = cardnumber;
            ExpiryDate = expiryDate;
        }

        public Fuelcard(string cardnumber, DateTime expiryDate, string pincode, List<Fuel> fueltypeList,
            Driver driver)
        {
            if (cardnumber == null)
            {
                throw new FuelcardException("Cardnumber cannot be null");
            }

            if (!validator.isValid(cardnumber))
            {
                throw new FuelcardException("The entered fuelcardnumber is not valid");
            }
            if (expiryDate < DateTime.Now)
            {
                throw new FuelcardException("This card is already expired");
            }
            Cardnumber = cardnumber;
            ExpiryDate = expiryDate;
            Pincode = pincode;
            FueltypeList = fueltypeList;
            Driver = driver;
            isActive = true;
        }

        public Fuelcard(string cardnumber, DateTime expiryDate, string pincode, Fuel fuel,
            Driver driver)
        {
            if (cardnumber == null)
            {
                throw new FuelcardException("Cardnumber cannot be null");
            }

            if (!validator.isValid(cardnumber))
            {
                throw new FuelcardException("The entered fuelcardnumber is not valid");
            }
            if (expiryDate < DateTime.Now)
            {
                throw new FuelcardException("This card is already expired");
            }
            Cardnumber = cardnumber;
            ExpiryDate = expiryDate;
            Pincode = pincode;
            FueltypeList.Add(fuel);
            Driver = driver;
            isActive = true;
        }

        public void addDriver(Driver d)
        {
            Driver = d;
        }

        public void removeDriver()
        {
            Driver = null;
        }

    }
}