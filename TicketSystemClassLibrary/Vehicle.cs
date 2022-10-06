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

        // Properties with regular getters/setters.
        protected string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }
        protected DateTime Date
        {
            get { return _date; }
            set { _date = value; }
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
        
    }
}
