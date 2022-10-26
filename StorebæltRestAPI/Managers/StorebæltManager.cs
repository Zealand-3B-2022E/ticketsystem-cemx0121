using StorebæltTicketLibrary;

namespace StorebæltRestAPI.Managers
{
    public class StorebæltManager : IStorebælt
    {
        private static List<StorebæltCar> _tickets = new List<StorebæltCar>()
        {
            new StorebæltCar("BY20099", new DateTime(2022,2, 14), true),
            new StorebæltCar("CE23453", new DateTime(2022,1, 13), false),
            new StorebæltCar("OK32349", new DateTime(2022,12, 22), true),
            new StorebæltCar("CK96534", new DateTime(2022,6, 2), false),
            new StorebæltCar("AN98651", new DateTime(2022,9, 19), false),
            new StorebæltCar("CS80802", new DateTime(2022,4, 7), false),
            new StorebæltCar("YX29865", new DateTime(2022,7, 2), true),
            new StorebæltCar("KK77543", new DateTime(2022,1, 31), true)
        };

        public StorebæltCar CreateTicket(StorebæltCar car)
        {
            _tickets.Add(car);
            return car;
        }

        public List<StorebæltCar> GetAllTickets()
        {
            if (_tickets.Count() == 0)
            {
                throw new ArgumentException("Der findes ingen billeter i øjeblikket!");
            }
            else
            {
                return new List<StorebæltCar>(_tickets);
            }
        }

        public StorebæltCar GetTicketByLicenseplate(string licenseplate)
        {
            if (_tickets.Find(c => c.LicensePlate == licenseplate) == null)
            {
                throw new KeyNotFoundException("Ingen billeter med denne nummerplade!");
            }
            else
            {
                return _tickets.Find(c => c.LicensePlate == licenseplate);
            }
        }
    }
}
