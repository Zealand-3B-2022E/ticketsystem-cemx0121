using StorebæltTicketLibrary;
namespace StorebæltRestAPI.Managers
{
    public interface IStorebælt
    {
        StorebæltCar CreateTicket(StorebæltCar car);
        List<StorebæltCar> GetAllTickets();
        StorebæltCar GetTicketByLicenseplate(string licenseplate);

    }
}
