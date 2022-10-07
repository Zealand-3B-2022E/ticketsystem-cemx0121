using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace ØresundTicketLibrary
{
    public class ØresundMC : Vehicle
    {
        public override double Price()
        {
            if (Brobizz == true)
            {
                return 73;
            }
            return 210;
        }

        public override string VehicleType()
        {
            return "Øresund MC";
        }
    }
}
