using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorebæltTicketLibrary;

namespace TicketSystemClassLibrary.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        Car car = new Car();
        MC mc = new MC();
        StorebæltCar sbCar = new StorebæltCar();

        [TestMethod()]
        public void CarPriceIsCorrectWithNoBrobizzTest()
        {
            // Arrange
            double expectedValue = 240;
            double actualValue = car.Price(false);
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
        public void MCPriceIsCorrectWithNoBrobizzTest()
        {
            // Arrange
            double expectedValue = 125;
            double actualValue = mc.Price(false);
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

        [TestMethod()]
        public void LicenseplateIsInvalid1Test()
        {
            // Act
            string licenseplateTestValue = "12345678";
            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => mc.LicensePlate = licenseplateTestValue);   
        }
        [TestMethod()]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("     ")]
        public void LicenseplateIsInvalid2Test(string licenseplateTest)
        {
            
            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => mc.LicensePlate = licenseplateTest);
        }

        [TestMethod]
        [DataRow("1")]
        [DataRow("1234567")]
        public void LicenseplateIsValidTest(string licenseplateTest)
        {
            // Act
            mc.LicensePlate = licenseplateTest;
            
            Assert.AreEqual(licenseplateTest, mc.LicensePlate);

        }

        [TestMethod()]
        public void CarPriceIsCorrectWithBrobizzTest()
        {
            // Arrange
            double expectedValue = 228;
            double actualValue = car.Price(true);
            // Act

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void MCPriceIsCorrectWithBrobizzTest()
        {
            // Arrange
            double expectedValue = 118.75;
            double actualValue = mc.Price(true);
            // Act

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void StorebæltCarPriceIsCorrectWithBrobizzAndWeekendTest()
        {
            // Arrange
            sbCar.Date = new DateTime(2022,10,8);
            double expectedValue = 182.4;
            // Act
            double actualValue = sbCar.Price(true);
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void StorebæltCarPriceIsCorrectWithBrobizzTest()
        {
            // Arrange
            sbCar.Date = new DateTime(2022,10,7);
            double expectedValue = 228;
            // Act
            double actualValue = sbCar.Price(true);
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void StorebæltCarPriceIsCorrectWithoutDiscountTest()
        {
            // Arrange
            sbCar.Date = new DateTime(2022,10,7);
            double expectedValue = 240;
            // Act
            double actualValue = sbCar.Price(false);
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }


    }
}