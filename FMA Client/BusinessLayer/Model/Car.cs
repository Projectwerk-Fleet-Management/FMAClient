using BusinessLayer.Exceptions;

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
        public Fuel FuelType { private set; get; }

        //Everything
        public Car(string Make, string Model, string Vin, string Licenseplate, string Colour, string Doors,
            Driver Driver, string Type, Fuel FuelType)
        {
            if (Make == null)
            {
                throw new CarException("Make of car is not allowed to be null");
            }
            this.Make = Make;
            if (Model == null)
            {
                throw new CarException("Model of a car cannot be null");
            }
            this.Model = Model;
            if (Vin == null)
                //todo: Vin check here somewhere
            {
                throw new CarException("The VIN of a car cannot be null");
            }
            this.Vin = Vin;
            if (Licenseplate == null)
            {
                //todo: check license plate
                throw new CarException("Licenseplate cannot be null");
            }
            this.Licenseplate = Licenseplate;
            this.Colour = Colour;
            this.Doors = Doors;
            this.Driver = Driver;
            if (Type == null)
            {
                throw new CarException("Type cannot be null");
            }
            this.Type = Type;
            this.FuelType = FuelType;
        }

        //Without colour, doors and driver
        public Car(string Make, string Model, string Vin, string Licenseplate, string Type, Fuel FuelType)
        {
            if (Make == null)
            {
                throw new CarException("Make of car is not allowed to be null");
            }
            this.Make = Make;
            if (Model == null)
            {
                throw new CarException("Model of a car cannot be null");
            }
            this.Model = Model;
            if (Vin == null)
            //todo: Vin check here somewhere
            {
                throw new CarException("The VIN of a car cannot be null");
            }
            this.Vin = Vin;
            if (Licenseplate == null)
            {
                //todo: check license plate
                throw new CarException("Licenseplate cannot be null");
            }
            this.Licenseplate = Licenseplate;
            if (Type == null)
            {
                throw new CarException("Type cannot be null");
            }
            this.Type = Type;
            this.FuelType = FuelType;
        }

        //Without doors and driver
        public Car(string Make, string Model, string Vin, string Licenseplate, string Colour, string Type, Fuel FuelType)
        {
            if (Make == null)
            {
                throw new CarException("Make of car is not allowed to be null");
            }
            this.Make = Make;
            if (Model == null)
            {
                throw new CarException("Model of a car cannot be null");
            }
            this.Model = Model;
            if (Vin == null)
            //todo: Vin check here somewhere
            {
                throw new CarException("The VIN of a car cannot be null");
            }
            this.Vin = Vin;
            if (Licenseplate == null)
            {
                //todo: check license plate
                throw new CarException("Licenseplate cannot be null");
            }
            this.Licenseplate = Licenseplate;
            this.Colour = Colour;

            if (Type == null)
            {
                throw new CarException("Type cannot be null");
            }
            this.Type = Type;
            this.FuelType = FuelType;
        }

        //Without driver
        public Car(string Make, string Model, string Vin, string Licenseplate, string Colour, string Doors, string Type, Fuel FuelType)
        {
            if (Make == null)
            {
                throw new CarException("Make of car is not allowed to be null");
            }
            this.Make = Make;
            if (Model == null)
            {
                throw new CarException("Model of a car cannot be null");
            }
            this.Model = Model;
            if (Vin == null)
            //todo: Vin check here somewhere
            {
                throw new CarException("The VIN of a car cannot be null");
            }
            this.Vin = Vin;
            if (Licenseplate == null)
            {
                //todo: check license plate
                throw new CarException("Licenseplate cannot be null");
            }
            this.Licenseplate = Licenseplate;
            this.Colour = Colour;
            this.Doors = Doors;
            if (Type == null)
            {
                throw new CarException("Type cannot be null");
            }
            this.Type = Type;
            this.FuelType = FuelType;
        }

        //Without colour and doors
        public Car(string Make, string Model, string Vin, string Licenseplate, Driver Driver, string Type, Fuel FuelType)
        {
            if (Make == null)
            {
                throw new CarException("Make of car is not allowed to be null");
            }
            this.Make = Make;
            if (Model == null)
            {
                throw new CarException("Model of a car cannot be null");
            }
            this.Model = Model;
            if (Vin == null)
            //todo: Vin check here somewhere
            {
                throw new CarException("The VIN of a car cannot be null");
            }
            this.Vin = Vin;
            if (Licenseplate == null)
            {
                //todo: check license plate
                throw new CarException("Licenseplate cannot be null");
            }
            this.Licenseplate = Licenseplate;
            this.Driver = Driver;
            if (Type == null)
            {
                throw new CarException("Type cannot be null");
            }
            this.Type = Type;
            this.FuelType = FuelType;
        }

        public void SetDriver(Driver driver)
        {
            this.Driver = driver;
        }
        public void RemoveDriver()
        {
            this.Driver = null;
        }
    }
}