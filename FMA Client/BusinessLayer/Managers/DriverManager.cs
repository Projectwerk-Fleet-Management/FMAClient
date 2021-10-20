using System.Data;
using BusinessLayer.Exceptions;
using BusinessLayer.Model;

namespace BusinessLayer.Managers
{
    public class DriverManager
    {
        public void SetAddress(Driver driver, Address address)
        {
            driver.SetAddress(address);
        }

        public void AssignCarToDriver(Driver driver, Car car)
        {
            driver.SetCar(car);
            car.SetDriver(driver);
        }

        public void AssignFuelcardToDriver(Driver driver, Fuelcard fuelcard)
        {
            driver.SetFuelcard(fuelcard);
            fuelcard.addDriver(driver);
        }

        public void RetractCarFromDriver(Driver driver)
        {
            driver.AssignedCar.RemoveDriver();
            driver.RemoveCar();
        }

        public void RetractFuelcardFromDriver(Driver driver)
        {
            driver.AssignedFuelcard.removeDriver();
            driver.RemoveFuelcard();
        }

        public void AddDriversLicense(Driver driver, LicenseType license)
        {
            driver.AddLicense(license);
        }

        public void RemoveDriversLicense(Driver driver, LicenseType license)
        {
            driver.RemoveLicense(license);
        }

        public void RetractDriverFromAll(Driver driver)
        {
            driver.AssignedFuelcard.removeDriver();
            driver.RemoveFuelcard();

            driver.AssignedCar.RemoveDriver();
            driver.RemoveCar();
        }

        
        
    }
}