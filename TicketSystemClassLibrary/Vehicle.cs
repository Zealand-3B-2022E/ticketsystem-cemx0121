using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// An abstract class Vehicle with two properties and two methods. Derived classes can inherit from this class and implement the abstract methods as needed. 
    /// </summary>
    public abstract class Vehicle
    {
        // Instansfelter
        private string _licensePlate;
        private DateTime _date;
        private bool _broBizz;

        // Properties with regular getters/setters.
        public string LicensePlate
        {
            get { return _licensePlate; }
            set 
            {
                CheckLicensePlateIsValid(value);
                _licensePlate = value;
            }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public bool Brobizz
        {
            get { return _broBizz; }
            set { _broBizz = value; }
        }
        /// <summary>
        /// An abstract method which returns the fixed price for the vehicle as a double
        /// </summary>
        /// <returns>Fixed price as a double</returns>
        public abstract double Price();

        /// <summary>
        /// An abstract method which returns the type of vehicle as a string. 
        /// </summary>
        /// <returns>Vehicle-type as a string</returns>
        public abstract string VehicleType();

        /// <summary>
        /// A private method that checks if the value trying to be set to LicensePlate property is valid, if not an appropiate exception is thrown.
        /// </summary>
        /// <param name="licenseplate">The value trying to be set to Licenseplate property</param>
        /// <exception cref="ArgumentNullException">Is thrown if the value is null, empty og empty spaces</exception>
        /// <exception cref="ArgumentOutOfRangeException">Is thrown if the value is above 7 characters</exception>
        private void CheckLicensePlateIsValid(string licenseplate)
        {
            if (string.IsNullOrEmpty(licenseplate) || string.IsNullOrWhiteSpace(licenseplate))
            {
                throw new ArgumentNullException("A licenseplate is required");
            }

            if (licenseplate.Length > 7)
            {
                throw new ArgumentOutOfRangeException("A licenseplate can not be more than 7 characters");
            }
        }
        
    }
}
