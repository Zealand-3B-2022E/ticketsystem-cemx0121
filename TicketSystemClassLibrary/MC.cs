using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// A MC class which inherit from the base class Vehicle. The two abstract methods from the base class is implemented for this specific class.
    /// </summary>
    public class MC : Vehicle
    {
        public override double Price()
        {
            if (Brobizz == true)
            {
                return 125 - (125 * 0.05);
            }
            return 125;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}
