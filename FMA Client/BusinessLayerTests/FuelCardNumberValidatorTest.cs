using Xunit;
using BusinessLayer.Validators;
using System;
using BusinessLayer.Exceptions;
using System.Collections.Generic;
using BusinessLayer;
using BusinessLayer.Model;

namespace BusinessLayerTests
{
    public class fuelcardNumberValidatorTests
    {
        //valid strings
        private string fuelcardNumber1 = "584685242598365896";
        private string fuelcardNumber2 = "7895 8958 3215 6593 23";
        private string fuelcardNumber3 = "1528.5896.5478.3259.29";
        private string fuelcardNumber4 = "8953-5478-5563-3332-77";

        //invalid strings
        private string fuelcardNumberIsEmptey = null;
        private string fuelcardNumberIsSpace = "";
        private string fuelcardNumberIsToLong = "8953-5478-5563-3332-777";
        private string fuelcardNumberContainsChar = "1528.5896.5478.3259.2@";

        private FuelcardNumberValidator toTest = new FuelcardNumberValidator();

        [Fact]
        public void isValid_true_fuelcardNumber1()
        {
            Assert.True(toTest.isValid(fuelcardNumber1));
        }
        [Fact]
        public void isValid_true_fuelcardNumber2()
        {
            Assert.True(toTest.isValid(fuelcardNumber2));
        }
        [Fact]
        public void isValid_true_fuelcardNumber3()
        {
            Assert.True(toTest.isValid(fuelcardNumber3));
        }
        [Fact]
        public void isValid_true_fuelcardNumber4()
        {
            Assert.True(toTest.isValid(fuelcardNumber4));
        }
        [Fact]
        public void isInValid_true_fuelcardNumberIsEmpty()
        {
            var ex = Assert.Throws<FuelcardNumberValidatorException>(() => toTest.isValid(fuelcardNumberIsEmptey));
            Assert.Equal("FuelcardNumberValidator - Fuel card number is empty", ex.Message);
        }
        [Fact]
        public void isInValid_true_fuelcardNumberIsToLong()
        {
            var ex = Assert.Throws<FuelcardNumberValidatorException>(() => toTest.isValid(fuelcardNumberIsToLong));
            Assert.Equal($"FuelcardNumberValidator - Fuel card number length isn't equal to 18", ex.Message);
        }
        [Fact]
        public void isInValid_true_fuelcardNumberIsSpace()
        {
            var ex = Assert.Throws<FuelcardNumberValidatorException>(() => toTest.isValid(fuelcardNumberIsSpace));
            Assert.Equal("FuelcardNumberValidator - Fuel card number is empty", ex.Message);
        }
        [Fact]
        public void isInValid_true_fuelcardNumberContainsChar()
        {
            var ex = Assert.Throws<FuelcardNumberValidatorException>(() => toTest.isValid(fuelcardNumberContainsChar));
            Assert.Equal("FuelcardNumberValidator - Fuel card number contains an invalid character (@/_/a/...)", ex.Message);
        }
    }
}

