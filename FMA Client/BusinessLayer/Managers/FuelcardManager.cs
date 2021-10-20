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

        //addfueltype
        //retractfueltype
        //blockfuelcard
        //retractdriverfromfuelcard
        //assigndrivertofuelcard
        //retractfuelcardfromall
        
    }
}