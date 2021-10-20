using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IDriverRepository
    {
        IReadOnlyList<Driver> GetDrivers();
        IReadOnlyList<Driver> GetDriversById(string id);
        IReadOnlyList<Driver> GetDriversByFirstName(string firstName);
        IReadOnlyList<Driver> GetDriversByLastName(string lastName);
        IReadOnlyList<Driver> GetDriversByDateOfBirth(DateTime dateOfBirth);
        IReadOnlyList<Driver> GetDriverByNIN(string nationalIdentificationNumber);
        IReadOnlyList<Driver> GetDriverByCar(Car car);
        bool Exists();
        void InsertDriver();
        void DeleteDriver();
        void UpdateDriver();
    }
}
