using TicketSystemClassLibrary;

namespace StorebæltTicketLibrary
{
    public class StorebæltCar : Vehicle
    {

        public override double Price(bool broBizz)
        {
            double standardPrice = 240;
            
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                standardPrice = standardPrice - (240 * 0.20);
            }
            if (broBizz == true)
            {
                return standardPrice - (standardPrice * Discount);
            }
            return standardPrice;
        }

        public override string VehicleType()
        {
            return "Storebælt Car";
        }
    }
}