namespace BusinessLayer.Managers
{
    public class FuelcardManager
    {
        public void SetPincode(Fuelcard fuelcard, string code)
        {
            fuelcard.SetPincode(code);
        }

        public void ChangePincode(Fuelcard fuelcard, string code)
        {
            fuelcard.ChangePincode(code);
        }

        public void AddFueltype(Fuelcard fuelcard, Fuel type)
        {
            fuelcard.AddFueltype(type);
        }

        public void RetractFueltype(Fuelcard fuelcard, Fuel type)
        {
            fuelcard.RetractFueltype(type);
        }

        public void BlockFuelard(Fuelcard card)
        {
            //ASK: Should blocking a card also remove it from a driver
            card.BlockFuelcard();
        }

        public void RetractDriverFromFuelcard(Fuelcard card)
        {
            card.Driver.RemoveFuelcard();
            card.removeDriver();
        }

        public void AssignDriverToFuelcard(Fuelcard card, Driver driver)
        {
            card.addDriver(driver);
            driver.SetFuelcard(card);
        }

    }
}