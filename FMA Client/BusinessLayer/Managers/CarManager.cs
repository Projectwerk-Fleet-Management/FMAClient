using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Exceptions;
using BusinessLayer.Interfaces;

namespace BusinessLayer.Managers
{
    public class CarManager
    {
        private ICarRepository _repo;
        public CarManager(ICarRepository repo)
        {
            _repo = repo;
        }

        public IReadOnlyList<Car>GetCars()
        {
            return _repo.GetCars();
        }

        public IReadOnlyList<Car> GetCars(string? vin, string? make, string? model, string? licensePlate, string? fuelType, string? colour, string? doors, string? driverId, string? vehicleType, bool strikt = true)
        {
            return _repo.GetCars(vin, make, model, licensePlate, fuelType, colour, doors, driverId, vehicleType, true);
        }

        public Car GetCarByCin(string vin)
        {
            try
            {
                IReadOnlyList < Car > carbyid = _repo.GetCars(vin, null, null, null, null, null, null, null, null, true);
                return carbyid.First();
            }
            catch (Exception e)
            {
                throw new CarmanagerException("couldn't get car by id");
            }
        }

    }
}