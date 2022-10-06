using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        Car car = new Car();
        MC mc = new MC();

        [TestMethod()]
        public void CarPriceIsCorrectTest()
        {
            // Arrange
            double expectedValue = 240;
            double actualValue = car.Price();
            // Act

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void CarVehicleTypeIsCorrectTest()
        {
            // Arrange
            string expectedString = "Car";
            string actualString = car.VehicleType();
            // Act

            // Assert
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod()]
        public void MCPriceIsCorrectTest()
        {
            // Arrange
            double expectedValue = 125;
            double actualValue = mc.Price();
            // Act

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void MCVehicleTypeIsCorrectTest()
        {
            // Arrange
            string expectedString = "MC";
            string actualString = mc.VehicleType();
            // Act

            // Assert
            Assert.AreEqual(expectedString, actualString);
        }
    }
}