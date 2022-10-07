using TicketSystemClassLibrary;

namespace StorebæltTicketLibrary
{
    public class StorebæltCar : Vehicle
    {

        public override double Price()
        {
            double standardPrice = 240;
            
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                standardPrice = standardPrice - (240 * 0.20);
            }
            if (Brobizz == true)
            {
                return standardPrice - (standardPrice * 0.05);
            }
            return standardPrice;
        }

        public override string VehicleType()
        {
            return "Storebælt Car";
        }
    }
}