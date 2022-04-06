using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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

            var db = new MyDbContext();


            var query = (from b in db.Bookings
                        join s in db.Societies
                        on b.society_Id equals s.society_ID
                        join c in db.Chairmen
                        on s.chairmanid equals c.chairmanid
                        join r in db.Rooms
                        on b.room_Id equals r.room_ID
                        join l in db.Locations
                        on r.location_ID equals l.location_ID
                        select new
                        {
                            RoomName = r.room_name,
                            LocationName = l.location_name,
                            SocietyName = s.society_name,
                            ChairmanName = c.chairman_name,
                            StartTime = b.booking_from,
                            EndTime = b.booking_to
                        }).ToList();

            return JsonConvert.SerializeObject(query);
            
        }
    }
}