using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Tests
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Price_ReturnsFixedPrice()
        {
            // Arrange
            var car = new Car("XX12345", DateTime.Now, false);

            // Act
            var result = car.Price();

            // Assert
            Assert.AreEqual(240, result);
        }


        [TestMethod]
        public void VehicleType_ReturnsCar()
        {
            // Arrange
            var car = new Car("XX12345", DateTime.Now, false);

            // Act
            var result = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", result);
        }


        [TestMethod]
        public void Licenseplate_ValidValue()
        {
            // Arrange
            var car = new Car("XX12345", DateTime.Now, false);
            var newLicenseplate = "XX54321";

            // Act
            car.Licenseplate = newLicenseplate;

            // Assert
            Assert.AreEqual(newLicenseplate, car.Licenseplate);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Licenseplate_InvalidValue()
        {
            // Arrange
            var car = new Car("XX12345", DateTime.Now, false);
            var invalidLicenseplate = "XX123456";

            // Act
            car.Licenseplate = invalidLicenseplate;

            // Assert håndteres af ArgumentException.
        }


        [TestMethod]
        public void PriceWithDiscount_BroBizzUsed()
        {
            // Arrange - true betyder at BroBizz bliver brugt.
            var car = new Car("XX12345", DateTime.Now, true);
            double expectedPriceWithDiscount = 240 * 0.95;

            // Act
            var result = car.PriceWithDiscount();

            // Assert - 0.01 betyder at forskellen mellem det forventede og det faktiske pris ikke må værestørre end 0.01 (1/100 = 1%)
            Assert.AreEqual(expectedPriceWithDiscount, result, 0.01);
        }


        [TestMethod]
        public void PriceWithDiscount_BroBizzNotUsed()
        {
            // Arrange - false betyder at BroBizz ikke bliver brugt.
            var car = new Car("XX12345", DateTime.Now, false);
            double expectedPrice = 240;

            // Act
            var result = car.PriceWithDiscount();

            // Assert
            Assert.AreEqual(expectedPrice, result, 0.01);
        }
    }







    [TestClass]
    public class McTest
    {
        [TestMethod]
        public void Price_ReturnsFixedPrice()
        {
            // Arrange
            var mc = new MC("XX12345", DateTime.Now, false);

            // Act
            var result = mc.Price();

            // Assert
            Assert.AreEqual(125, result);
        }


        [TestMethod]
        public void VehicleType_ReturnsMC()
        {
            // Arrange
            var mc = new MC("XX12345", DateTime.Now, false);

            // Act
            var result = mc.VehicleType();

            //Assert
            Assert.AreEqual("MC", result);
        }


        [TestMethod]
        public void Licenseplate_ValidValue()
        {
            // Arrange
            var mc = new MC("XX12345", DateTime.Now, false);
            var newLicenseplate = "XX54321";

            // Act
            mc.Licenseplate = newLicenseplate;

            // Assert
            Assert.AreEqual(newLicenseplate, mc.Licenseplate);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Licenseplate_InvalidValue()
        {
            // Arrange
            var mc = new MC("XX12345", DateTime.Now, false);
            var invalidLicenseplate = "XX123456";

            // Act
            mc.Licenseplate = invalidLicenseplate;

            // Assert håndteres af ArgumentException.
        }

        [TestMethod]
        public void PriceWithDiscount_BroBizzUsed()
        {
            // Arrange - true betyder at BroBizz bliver brugt.
            var mc = new MC("XX12345", DateTime.Now, true);
            double expectedPriceWithDiscount = 125 * 0.95;

            // Act
            var result = mc.PriceWithDiscount();

            // Assert - 0.01 betyder at forskellen mellem det forventede og det faktiske pris ikke må værestørre end 0.01 (1/100 = 1%)
            Assert.AreEqual(expectedPriceWithDiscount, result, 0.01);
        }


        [TestMethod]
        public void PriceWithDiscount_BroBizzNotUsed()
        {
            // Arrange - false betyder at BroBizz ikke bliver brugt.
            var mc = new MC("XX12345", DateTime.Now, false);
            double expectedPrice = 125;

            // Act
            var result = mc.PriceWithDiscount();

            // Assert
            Assert.AreEqual(expectedPrice, result, 0.01);
        }
    }
}