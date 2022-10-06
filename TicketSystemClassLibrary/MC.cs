using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// En klasse MC der har to properties og to metoder.
    /// </summary>
    public class MC
    {
        // Instansfelter
        private string _licensePlate;
        private DateTime _date;
        // Properties med almindelige getter/setter
        public string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        /// <summary>
        /// En metode der retunere den faste pris som en double
        /// </summary>
        /// <returns>Fast pris: 125</returns>
        public double Price()
        {
            return 125;
        }
        /// <summary>
        /// En metode der retunere hvilken køretøj type som en string
        /// </summary>
        /// <returns>"MC"</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
