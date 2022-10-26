using Microsoft.AspNetCore.Mvc;
using StorebæltRestAPI.Managers;
using StorebæltTicketLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StorebæltRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorebæltController : ControllerBase
    {
        private IStorebælt storebæltManager = new StorebæltManager();

        // GET: api/<StorebæltController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAll()
        {
            try
            {
                List<StorebæltCar> searchAllTickets = storebæltManager.GetAllTickets();
                return Ok(searchAllTickets);
            }
            catch (ArgumentException ae)
            {
                return NotFound(ae.Message);
            }
        }

        // GET api/<StorebæltController>/5
        [HttpGet("{licenseplate}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetByLicenseplate(string licenseplate)
        {
            try
            {
                StorebæltCar searchedTicketByLicenseplate = storebæltManager.GetTicketByLicenseplate(licenseplate);
                return Ok(searchedTicketByLicenseplate);
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }
        }

        // POST api/<StorebæltController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        public StorebæltCar Post([FromBody] StorebæltCar car)
        {
            return storebæltManager.CreateTicket(car);
        }

    }
}
