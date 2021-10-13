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

        //TODO: GetDriverDetails() / (Set / Update / Remove) -> Address, Licenses (Only Update)
        public void SetAssignedCar(Car car)
        {
            if (car == null) throw new DriverException("SetAssignedCar - Driver is empty");
            if (this.AssignedCar != null) throw new DriverException("SetAssignedCar - Driver already has car assigned");
            if (car.Driver != null)
            {
                throw new DriverException("SetAssignedCar - Car already has driver assigned");
            } else
            {
                car.SetDriver(this);
                this.AssignedCar = car;
            }          
        }
        public void RemoveAssignedCar()
        {
            if (this.AssignedCar == null)
            {
                throw new DriverException("RemoveAssignedCar - Driver doesn't have a car");
            } else
            {
                this.AssignedCar.RemoveDriver();
                this.AssignedCar = null;
            }
        }
        public void UpdateAssignedCar(Car car)
        {
            if (car == null) throw new DriverException("SetAssignedCar - Driver is empty");
            if (this.AssignedCar == null) throw new DriverException("UpdateAssignedCar - Driver doesn't have a car");
            if (this.AssignedCar == car) 
            {
                throw new DriverException("UpdateAssignedCar - Car matches driver's car");
            } else
            {
                this.AssignedCar.RemoveDriver();
                this.AssignedCar = car;
                car.SetDriver(this);
            }            
        }

        public void SetFuelcard(Fuelcard fuelcard)
        {
            if (fuelcard == null) throw new DriverException("SetFuelcard - Fuelcard is empty");
            if (this.AssignedFuelcard != null) throw new DriverException("SetFuelcard - Driver already has a fuelcard assigned");
            if (fuelcard.Driver != null)
            {
                throw new DriverException("SetFuelcard - Fuelcard already has a driver assigned");
            } else
            {
                this.AssignedFuelcard = fuelcard;
                fuelcard.SetDriver(this);
            }
        }
        public void RemoveFuelcard()
        {
            if (this.AssignedFuelcard == null)
            { 
                throw new DriverException("SetFuelcard - Driver doesn't have a fuelcard assigned");
            } else
            {
                this.AssignedFuelcard = null;
                fuelcard.RemoveDriver();
            }
        }
        public void UpdateFuelcard(Fuelcard fuelcard)
        {
            if (fuelcard == null) throw new DriverException("SetFuelcard - Fuelcard is empty");
            if (this.AssignedFuelcard == null) throw new DriverException("SetFuelcard - Driver doesn't have a fuelcard assigned");
            if (fuelcard.Driver != null)
            {
                throw new DriverException("SetFuelcard - Fuelcard already has a driver assigned");
            } else
            {
                this.AssignedFuelcard.RemoveFuelcard();
                this.AssignedFuelcard = fuelcard;
                fuelcard.SetDriver(this);
            }
        }
    }
}