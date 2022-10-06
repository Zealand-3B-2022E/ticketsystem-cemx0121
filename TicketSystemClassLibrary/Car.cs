namespace TicketSystemClassLibrary
{
    /// <summary>
    /// A Car class which inherit from the base class Vehicle. The two abstract methods from the base class is implemented for this specific class.
    /// </summary>
    public class Car : Vehicle
    {
        public override double Price(bool BroBizz)
        {
            if (BroBizz == true)
            {
                double rabatIKroner = 240  * Discount;
                return 240 - rabatIKroner;
            }
            return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}