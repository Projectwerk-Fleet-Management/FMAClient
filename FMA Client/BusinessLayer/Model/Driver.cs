using System;
using System.Collections.Generic;
using BusinessLayer.Model;
using BusinessLayer.Exceptions;

namespace BusinessLayer
{
    public class Driver
    {
        public string Id { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public Address Address { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public int NationalIdentificationNumber { get; private set; }
        public List<LicenseType> Licenses { get; private set; }
        public Car AssignedCar { get; private set; }
        public Fuelcard AssignedFuelcard { get; private set; }

        public Driver(string id, string lastName, string firstName, DateTime dateOfBirth, int nationalIdentificationNumber, List<LicenseType> licenses)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            NationalIdentificationNumber = nationalIdentificationNumber;
            Licenses = licenses;
        }

        public Driver(string id, string lastName, string firstName, Address address, DateTime dateOfBirth, int nationalIdentificationNumber, List<LicenseType> licenses, Car assignedCar, Fuelcard assignedFuelcard)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Address = address;
            DateOfBirth = dateOfBirth;
            NationalIdentificationNumber = nationalIdentificationNumber;
            Licenses = licenses;
            AssignedCar = assignedCar;
            AssignedFuelcard = assignedFuelcard;
        }

        //TODO: GetDriverDetails() 

    }
}