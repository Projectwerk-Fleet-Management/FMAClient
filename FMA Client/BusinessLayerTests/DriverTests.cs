using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BusinessLayer;
using BusinessLayer.Model;
using BusinessLayer.Exceptions;

namespace BusinessLayerTests
{
    public class DriverTests
    {
        public List<LicenseType> licenses = new List<LicenseType> {LicenseType.A, LicenseType.BE };
        //public Driver toTest = new("1", "Batselier", "Bryan", new DateTime(1993, 11, 23), "93.11.23-283.87", new List<LicenseType> { LicenseType.A, LicenseType.BE });
        
        //Tests without car or fuelcard
        [Fact]
        public void Test_Ctor_NoCar_NoFuelcard_Valid()
        {
            Driver toTest = new Driver("1", "Batselier", "Bryan", new DateTime(1993, 11, 23), "93.11.23-283.87", licenses);

            Assert.Equal("1", toTest.Id);
            Assert.Equal("Batselier", toTest.LastName);
            Assert.Equal("Bryan", toTest.FirstName);
            Assert.Equal(new DateTime(1993, 11, 23), toTest.DateOfBirth);
            Assert.Equal("93.11.23-283.87", toTest.NationalIdentificationNumber);
            Assert.Equal(new List<LicenseType> { LicenseType.A, LicenseType.BE }, toTest.Licenses);
        }

        [Theory]
        [InlineData("-10")]
        [InlineData("-0.5")]
        [InlineData("0")]
        public void Test_Ctor_NoCar_NoFuelcard_Invalid(string id)
        {
            Assert.Throws<DriverException>(() => new Driver(id, "Batselier", "Bryan", new DateTime(1993, 11, 23), "93.11.23-283.87", licenses));
        }

        //Tests with car and without fuelcard
        [Fact]
        public void Test_Ctor_Car_NoFuelcard_Valid()
        {

        }
        [Fact]
        public void Test_Ctor_Car_NoFuelcard_Invalid()
        {

        }

        //Tests without car and with fuelcard
        [Fact]
        public void Test_Ctor_NoCar_Fuelcard_Valid()
        {

        }
        [Fact]
        public void Test_Ctor_NoCar_Fuelcard_Invalid()
        {

        }

        //Tests with car and fuelcard
        [Fact]
        public void Test_Ctor_Car_Fuelcard_Valid()
        {

        }
        [Fact]
        public void Test_Ctor_Car_Fuelcard_Invalid()
        {

        }
    }
}
