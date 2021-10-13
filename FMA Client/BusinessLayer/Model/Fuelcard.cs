using System;
using System.Collections.Generic;
using BusinessLayer.Exceptions;

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

        public Fuelcard(string cardnumber, DateTime expiryDate)
        {
            if (cardnumber == null)
            {
                throw new FuelcardException("Cardnumber cannot be null");
            }

            if (expiryDate < DateTime.Now)
            {
                throw new FuelcardException("This card is already expired");
                //TODO: Ask if this is needed
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

            if (expiryDate < DateTime.Now)
            {
                throw new FuelcardException("This card is already expired");
                //TODO: Ask if this is needed
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

            if (expiryDate < DateTime.Now)
            {
                throw new FuelcardException("This card is already expired");
                //TODO: Ask if this is needed
            }
            Cardnumber = cardnumber;
            ExpiryDate = expiryDate;
            Pincode = pincode;
            FueltypeList.Add(fuel);
            Driver = driver;
            isActive = true;
        }

    }
}