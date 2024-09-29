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



    [TestClass]
    public class McTest
    {
        [TestMethod]
        public void Price_ReturnsFixedPrice()
        {
            // Arrange
            var mc = new MC();

            // Act
            var result = mc.Price();

            // Assert
            Assert.AreEqual(125, result);
        }


        [TestMethod]
        public void Vehicle_ReturnsMC()
        {
            // Arrange
            var mc = new MC();

            // Act
            var result = mc.Vehicle();

            //Assert
            Assert.AreEqual("MC", result);
        }
    }
}