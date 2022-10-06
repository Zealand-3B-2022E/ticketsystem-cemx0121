namespace TicketSystemClassLibrary
{
    /// <summary>
    /// En public klasse Car, som har to Properties (string Licenseplate, DateTime Date) samt to metoder (Price(), VehicleType())
    /// </summary>
    public class Car
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
        /// <returns>Fast pris: 240</returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// En metode der retunere hvilken køretøj type som en string
        /// </summary>
        /// <returns>"Car"</returns>
        public string VehicleType()
        {
            return "Car";
        }

    }
}