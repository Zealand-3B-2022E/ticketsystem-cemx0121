namespace TicketSystemClassLibrary
{
    /// <summary>
    /// A Car class which inherit from the base class Vehicle. The two abstract methods from the base class is implemented for this specific class.
    /// </summary>
    public class Car : Vehicle
    {
        public override double Price()
        {
            if (Brobizz == true)
            {
                return 240 - (240 * 0.05);
            }
            return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}