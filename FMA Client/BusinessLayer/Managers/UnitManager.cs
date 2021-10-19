using System;
using System.Runtime.Intrinsics.Arm;
using BusinessLayer.Model;

namespace BusinessLayer.Managers
{
    public class UnitManager
    {
        public void AssignFuelcard(Driver driver, Fuelcard fuelcard)
        {
            driver.SetFuelcard(fuelcard);
            fuelcard.addDriver(driver);
        }

        public void RetractFuelCard(Driver driver, Fuelcard fuelcard)
        {
            driver.RemoveFuelcard();
            fuelcard.removeDriver();
        }

        public void AssignDriver(Car car, Driver driver)
        {
            driver.SetCar(car);
            car.SetDriver(driver);
        }


    }
}