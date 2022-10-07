using TicketSystemClassLibrary;

namespace ØresundTicketLibrary
{
    public class ØresundCar : Vehicle
    {
        public override double Price()
        {
            if (Brobizz == true)
            {
                return 161;
            }
            return 410;
        }

        public override string VehicleType()
        {
            return "Øresund Car";
        }
    }
}