using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoreBaeltTicketLibraryTests
{
    [TestClass]
    public class StoreBaeltCarsTests
    {
        [TestMethod]
        public void PriceWithDiscount_CarWithoutBroBizzNoWeekend() // Tester en bil uden BroBizz og uden weekend.
        {
            // Arrange
            var car = new Car("XX12345", new DateTime(2024,10, 2), false);
            var storeBaeltCars = new StoreBaeltCars();

            // Act
            double result = storeBaeltCars.PriceWithDiscount(car);

            // Assert
            Assert.AreEqual(240, result);
        }


        [TestMethod]
        public void PriceWithDiscount_CarWithBroBozzWithoutWeekend() // Tester en bil med BroBizz og uden weekend (5% rabat).
        {
            // Arrange
            var car = new Car("XX12345", new DateTime(2024, 10, 4), true);
            var storeBaeltCars = new StoreBaeltCars();

            // Act
            double result = storeBaeltCars.PriceWithDiscount(car);

            // Assert
            Assert.AreEqual(240 * 0.95, result);
        }


        [TestMethod]
        public void PriceWithDiscount_CarWithoutBroBizzWithWeekend() // Tester en bil uden BroBizz og med weekend (20% rabat).
        {
            // Arrange
            var car = new Car("XX12345", new DateTime(2024, 10, 5), false);
            var storeBaeltCars = new StoreBaeltCars();

            // Act
            double result = storeBaeltCars.PriceWithDiscount(car);

            // Assert
            Assert.AreEqual(240 * 0.80, result);
        }

        [TestMethod]
        public void PriceWithDiscount_CarWithBroBizzWithWeekend() // Tester en bil med BroBizz og med weekend (20% rabat + 5% rabat).
        {
            // Arrange
            var car = new Car("XX12345", new DateTime(2024, 10, 5), true);
            var storeBaeltCars = new StoreBaeltCars();

            // Act
            double result = storeBaeltCars.PriceWithDiscount(car);

            // Assert
            Assert.AreEqual(240 * 0.80 * 0.95, result);
        }
    }
}