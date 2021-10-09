namespace BusinessLayer
{
    public class Car
    {
        private string _make;
        private string _model;
        private string _vin;
        private string _licenseplate;
        private string _colour;
        private string _doors;
        private Driver _driver;
        private string _type;

        public Car(string make, string model, string vin, string licenseplate, string colour, string doors,
            Driver driver, string type)
        {
            _make = make;
            _model = model;
            _vin = vin;
            _licenseplate = licenseplate;
            _colour = colour;
            _doors = doors;
            _driver = driver;
            _type = type;
        }



    }
}