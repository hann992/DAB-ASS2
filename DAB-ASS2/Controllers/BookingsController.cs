using Microsoft.AspNetCore.Mvc;

namespace DAB_ASS2.Controllers
{
    [ApiController]
    [Route("Bookings/")]
    public class BookingsController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            // Samle info og sende retur...
            // Get a list of booked rooms (name, location), with the booking 
            // society(name, chairmen) and the times it is booked.




            return "Retur";
        }
    }
}
