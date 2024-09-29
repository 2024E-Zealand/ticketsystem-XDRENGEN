using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class CarTest
    {
        [TestMethod]
        public void Price_ReturnsFixedPrice()
        {
            // Arrange
            var car = new Car();

            // Act
            var result = car.Price();

            // Assert
            Assert.AreEqual(240, result);
        }


        [TestMethod]
        public void VehicleType_ReturnsCar()
        {
            // Arrange
            var car = new Car();

            // Act
            var result = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", result);
        }
    }
}