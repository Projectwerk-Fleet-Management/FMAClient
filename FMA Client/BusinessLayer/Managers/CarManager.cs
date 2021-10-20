namespace BusinessLayer.Managers
{
    public class CarManager
    {
        public void AssignDriverToCar(Car car, Driver driver)
        {
            car.SetDriver(driver);
            driver.SetCar(car);
        }

        public void RetractDriverFromCar(Car car)
        {
            car.Driver.RemoveCar();
            car.RemoveDriver();
        }

        public void SetColour(string colour, Car car)
        {
            car.SetColor(colour);

        }

        public void SetDoors(Car car, string doors)
        {
            car.SetDoors(doors);
        }
    }
}