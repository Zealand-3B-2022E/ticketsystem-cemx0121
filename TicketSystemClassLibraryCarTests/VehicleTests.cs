using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorebæltTicketLibrary;
using ØresundTicketLibrary;

namespace TicketSystemClassLibrary.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        Car car = new Car();
        MC mc = new MC();
        StorebæltCar sbCar = new StorebæltCar();
        ØresundCar øsCar = new ØresundCar();
        ØresundMC øsMC = new ØresundMC();

        [TestMethod()]
        public void CarPriceIsCorrectWithNoBrobizzTest()
        {
            // Arrange
            car.Brobizz = false;
            // Act
            double expectedValue = 240;
            double actualValue = car.Price();
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
            mc.Brobizz = false;
            // Act
            double expectedValue = 125;
            double actualValue = mc.Price();
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
            car.Brobizz = true;
            // Act
            double expectedValue = 228;
            double actualValue = car.Price();
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void MCPriceIsCorrectWithBrobizzTest()
        {
            // Arrange
            mc.Brobizz = true;
            // Act
            double expectedValue = 118.75;
            double actualValue = mc.Price();
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void StorebæltCarPriceIsCorrectWithBrobizzAndWeekendTest()
        {
            // Arrange
            sbCar.Date = new DateTime(2022,10,8);
            sbCar.Brobizz = true;
            // Act
            double expectedValue = 182.4;
            double actualValue = sbCar.Price();
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void StorebæltCarPriceIsCorrectWithBrobizzTest()
        {
            // Arrange
            sbCar.Date = new DateTime(2022,10,7);
            sbCar.Brobizz= true;
            // Act
            double expectedValue = 228;
            double actualValue = sbCar.Price();
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void StorebæltCarPriceIsCorrectWithoutDiscountTest()
        {
            // Arrange
            sbCar.Date = new DateTime(2022,10,7);
            sbCar.Brobizz = false;
            // Act
            double expectedValue = 240;
            double actualValue = sbCar.Price();
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void ØresundCarPriceIsCorrectWithBrobizzTest()
        {
            // Arrange
            øsCar.Brobizz = true;
            // Act
            double expectedValue = 161;
            double actualValue = øsCar.Price();
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void ØresundCarPriceIsCorrectWithoutBrobizzTest()
        {
            // Arrange
            øsCar.Brobizz = false;
            // Act
            double expectedValue = 410;
            double actualValue = øsCar.Price();
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void ØresundMCPriceIsCorrectWithBrobizzTest()
        {
            // Arrange
            øsMC.Brobizz = true;
            // Act
            double expectedValue = 73;
            double actualValue = øsMC.Price();
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void ØresundMCPriceIsCorrectWithoutBrobizzTest()
        {
            // Arrange
            øsMC.Brobizz = false;
            // Act
            double expectedValue = 210;
            double actualValue = øsMC.Price();
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}