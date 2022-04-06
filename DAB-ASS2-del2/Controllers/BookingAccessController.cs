using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DAB_ASS2.Controllers
{
    [ApiController]
    [Route("BookingAccess/")]
    public class BookingAccessController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            /*
            Given a key-responsible the municipalities would like to offer a 
            service, where the key-responsible can print a list of all future 
            bookings, with access information.
            */

            var db = new MyDbContext();

            int keyResponsible = 5;

            var query = (from b in db.Bookings

                         join s in db.Societies
                         on b.society_Id equals s.society_ID

                         join k in db.keyResponsibles
                         on s.KeyResponsible_Id equals k.key_responsible_ID

                         join r in db.Rooms
                         on b.room_Id equals r.room_ID

                         join l in db.Locations
                         on r.location_ID equals l.location_ID

                         join la in db.LocationAccesses
                         on l.location_ID equals la.locationId

                         where k.key_responsible_ID == keyResponsible

                         where b.booking_to > DateTime.Now

                         select new
                         {
                                RoomName        = r.room_name,
                                LocationName    = l.location_name,
                                BookingFrom     = b.booking_from,
                                BookingTo       = b.booking_to,
                                AccessKeyPickUp = la.location_key_pickup_address,
                                AccessCode      = la.locationcode

                         }).ToList();

            return JsonConvert.SerializeObject(query);

        }
    }
}