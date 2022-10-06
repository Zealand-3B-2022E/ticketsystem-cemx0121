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
        public override double Price(bool BroBizz)
        {
            if (BroBizz == true)
            {
                double rabatIKroner = 125 * Discount;
                return 125 - rabatIKroner;
            }
            return 125;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}
