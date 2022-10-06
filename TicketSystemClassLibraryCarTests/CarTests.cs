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
    public class CarTests
    {
        Car car = new Car();

        [TestMethod()]
        public void PriceIsCorrectTest()
        {
            // Arrange
            double expectedValue = 240;
            double actualValue = car.Price();
            // Act

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void VehicleTypeIsCorrectTest()
        {
            // Arrange
            string expectedString = "Car";
            string actualString = car.VehicleType();
            // Act

            // Assert
            Assert.AreEqual(expectedString, actualString);
        }
    }
}