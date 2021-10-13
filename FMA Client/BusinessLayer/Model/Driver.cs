using System;
using System.Collections.Generic;
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
            if (id == null) throw new DriverException("id cannot be null");
            if (Convert.ToInt64(Math.Floor(decimal.Parse(id))) <= 0) throw new DriverException("Id is less or equal to zero");
            if (lastName == null) throw new DriverException("Last name cannot be null");
            if (firstName == null) throw new DriverException("First name cannot be null");
            if (dateOfBirth == null) throw new DriverException("Date of birth cannot be null");
            if (NINValidator.isValid(nationalIdentificationNumber) == false) throw new DriverException("National identification number is not valid");
            if (licenses == null) throw new DriverException("Licenses cannot be null");

            Id = id;
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            NationalIdentificationNumber = nationalIdentificationNumber;
            Licenses = licenses;
        }

        //Constructor with car and without fuelcard
        public Driver(string id, string lastName, string firstName, DateTime dateOfBirth, string nationalIdentificationNumber, List<LicenseType> licenses, Car assignedCar)
        {
            if (id == null) throw new DriverException("Id cannot be null");
            if (Convert.ToInt64(Math.Floor(decimal.Parse(id))) <= 0) throw new DriverException("Id is less or equal to zero");
            if (lastName == null) throw new DriverException("Last name cannot be null");
            if (firstName == null) throw new DriverException("First name cannot be null");
            if (dateOfBirth == null) throw new DriverException("Date of birth cannot be null");
            if (NINValidator.isValid(nationalIdentificationNumber) == false) throw new DriverException("National identification number is not valid");
            if (licenses == null) throw new DriverException("Licenses cannot be null");
            if (assignedCar == null) throw new DriverException("Car cannot be null");

            Id = id;
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            NationalIdentificationNumber = nationalIdentificationNumber;
            Licenses = licenses;
            AssignedCar = assignedCar;
        }

        //Constructor without car and with fuelcard
        public Driver(string id, string lastName, string firstName, DateTime dateOfBirth, string nationalIdentificationNumber, List<LicenseType> licenses, Fuelcard assignedFuelcard)
        {
            if (id == null) throw new DriverException("Id cannot be null");
            if (Convert.ToInt64(Math.Floor(decimal.Parse(id))) <= 0) throw new DriverException("Id is less or equal to zero");
            if (lastName == null) throw new DriverException("Last name cannot be null");
            if (firstName == null) throw new DriverException("First name cannot be null");
            if (dateOfBirth == null) throw new DriverException("Date of birth cannot be null");
            if (NINValidator.isValid(nationalIdentificationNumber) == false) throw new DriverException("National identification number is not valid");
            if (licenses == null) throw new DriverException("Licenses cannot be null");
            if (assignedFuelcard == null) throw new DriverException("Fuelcard cannot be null");

            Id = id;
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            NationalIdentificationNumber = nationalIdentificationNumber;
            Licenses = licenses;
            AssignedFuelcard = assignedFuelcard;
        }

        //Constructor with car and fuelcard
        public Driver(string id, string lastName, string firstName, DateTime dateOfBirth, string nationalIdentificationNumber, List<LicenseType> licenses, Car assignedCar, Fuelcard assignedFuelcard)
        {
            if (id == null) throw new DriverException("Id cannot be null");
            if (Convert.ToInt64(Math.Floor(decimal.Parse(id))) <= 0) throw new DriverException("Id is less or equal to zero");
            System.Diagnostics.Debug.WriteLine(this.Id);
            if (lastName == null) throw new DriverException("Last name cannot be null");
            if (firstName == null) throw new DriverException("First name cannot be null");
            if (dateOfBirth == null) throw new DriverException("Date of birth cannot be null");
            if (NINValidator.isValid(nationalIdentificationNumber) == false) throw new DriverException("National identification number is not valid");
            if (licenses == null) throw new DriverException("Licenses cannot be null");
            if (assignedCar == null) throw new DriverException("Car cannot be null");
            if (assignedFuelcard == null) throw new DriverException("Fuelcard cannot be null");

            Id = id;
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            NationalIdentificationNumber = nationalIdentificationNumber;
            Licenses = licenses;
            AssignedCar = assignedCar;
            AssignedFuelcard = assignedFuelcard;
        }
    }
}