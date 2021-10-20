using System;
using System.Collections.Generic;
using System.ComponentModel;
using BusinessLayer.Model;
using BusinessLayer.Exceptions;
using BusinessLayer.Validators;

namespace BusinessLayer
{
    public class Driver
    {
        public string Id { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public Address Address { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string NationalIdentificationNumber { get; private set; }
        public List<LicenseType> Licenses { get; private set; }
        public Car AssignedCar { get; private set; }
        public Fuelcard AssignedFuelcard { get; private set; }
        private static NINValidator NINValidator = new NINValidator();

        //TODO: Address add to constructors
        //Constructor without car and fuelcard
        public Driver(string id, string lastName, string firstName, DateTime dateOfBirth, string nationalIdentificationNumber, List<LicenseType> licenses)
        {
            SetId(id);
            SetLastName(lastName);
            SetFirstName(firstName);
            SetDateOfBirth(dateOfBirth);
            SetNationalIdentificationNumber(nationalIdentificationNumber);
            SetLicenses(licenses);   
        }

        //Constructor with car and without fuelcard
        public Driver(string id, string lastName, string firstName, DateTime dateOfBirth, string nationalIdentificationNumber, List<LicenseType> licenses, Car assignedCar)
        {
            SetId(id);
            SetLastName(lastName);
            SetFirstName(firstName);
            SetDateOfBirth(dateOfBirth);
            SetNationalIdentificationNumber(nationalIdentificationNumber);
            SetLicenses(licenses);
            SetCar(assignedCar);
        }

        //Constructor without car and with fuelcard
        public Driver(string id, string lastName, string firstName, DateTime dateOfBirth, string nationalIdentificationNumber, List<LicenseType> licenses, Fuelcard assignedFuelcard)
        {
            SetId(id);
            SetLastName(lastName);
            SetFirstName(firstName);
            SetDateOfBirth(dateOfBirth);
            SetNationalIdentificationNumber(nationalIdentificationNumber);
            SetLicenses(licenses);
            SetFuelcard(assignedFuelcard);
        }

        //Constructor with car and fuelcard
        public Driver(string id, string lastName, string firstName, DateTime dateOfBirth, string nationalIdentificationNumber, List<LicenseType> licenses, Car assignedCar, Fuelcard assignedFuelcard)
        {          
            SetId(id);
            SetLastName(lastName);
            SetFirstName(firstName);
            SetDateOfBirth(dateOfBirth);
            SetNationalIdentificationNumber(nationalIdentificationNumber);
            SetLicenses(licenses);
            SetCar(assignedCar);
            SetFuelcard(assignedFuelcard);
        }

        //Setting of variables
        public void SetId(string id)
        {
            if (id == null) throw new DriverException("id cannot be null");
            if (Convert.ToInt64(Math.Floor(decimal.Parse(id))) <= 0) throw new DriverException("Id is less or equal to zero");
            this.Id = id;
        }
        public void SetLastName(string lastName)
        {
            if (lastName == null) throw new DriverException("Last name cannot be null");
            this.LastName = lastName;
        }
        public void SetFirstName(string firstName)
        {
            if (firstName == null) throw new DriverException("First name cannot be null");
            this.FirstName = firstName;
        }
        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth == null) throw new DriverException("Date of birth cannot be null");
            this.DateOfBirth = dateOfBirth;
        }
        public void SetNationalIdentificationNumber (string nationalIdentificationNumber)
        {
            if (NINValidator.isValid(nationalIdentificationNumber) == false) throw new DriverException("National identification number is not valid");
            this.NationalIdentificationNumber = nationalIdentificationNumber;
        }
        public void SetLicenses (List<LicenseType> licenses)
        {
            if (licenses == null) throw new DriverException("Licenses cannot be null");
            this.Licenses = licenses;
        }
        public void SetCar(Car car)
        {
            if (car == null) throw new DriverException("Car cannot be null");
            AssignedCar = car;
        }

        public void RemoveCar()
        {
            if (AssignedCar == null) throw new DriverException("Car is already null");
            AssignedCar = null;
        }
        public void SetFuelcard(Fuelcard fuelcard)
        {
            if (fuelcard == null) throw new DriverException("Fuelcard cannot be null");
            AssignedFuelcard = fuelcard;
        }

        //Removing of variables
        public void RemoveFuelcard()
        {
            if (this.AssignedFuelcard == null) throw new DriverException("There is no fuelcard assigned to this driver");
            AssignedFuelcard = null;
        }

        public void SetAddress(Address address)
        {
            if (address == null) throw new DriverException("Address cannot be null");
            Address = address;
        }

        public void AddLicense(LicenseType license)
        {
            if (Licenses.Contains(license)) throw new DriverException("Driver already has this license");
            Licenses.Add(license);
        }

        public void RemoveLicense(LicenseType license)
        {
            if (!Licenses.Contains(license)) throw new DriverException("Driver does not have this license");
            Licenses.Remove(license);
        }

        
    }
}