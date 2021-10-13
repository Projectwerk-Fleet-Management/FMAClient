namespace BusinessLayer
{
    public class Car
    {
        public string Make { private set; get; }
        public string Model { private set; get; }
        public string Vin { private set; get; }
        public string Licenseplate { private set; get; }
        public string Colour { private set; get; }
        public string Doors { private set; get; }
        public Driver Driver { private set; get; }
        public string Type { private set; get; }

        public Car(string Make, string Model, string Vin, string Licenseplate, string Colour, string Doors,
            Driver Driver, string Type)
        {
            this.Make = Make;
            this.Model = Model;
            this.Vin = Vin;
            this.Licenseplate = Licenseplate;
            this.Colour = Colour;
            this.Doors = Doors;
            this.Driver = Driver;
            this.Type = Type;
        }

        // TODO: GetCarDetail() / (Set / Update / Remove) -> Driver, Colour, Doors 
        public void SetDriver(Driver driver)
        {

        }
        public void RemoveDriver()
        {

        }
    }
}