using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DAB_ASS2.Controllers
{
    [ApiController]
    [Route("MunicipalityInfo/")]
    public class MunicipalityInfoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            // Samle info og sende retur...
            // Get all municipality information: rooms (addresses)
            var db = new MyDbContext();

            var query = (from r in db.Rooms

                         join l in db.Locations
                         on r.location_ID equals l.location_ID

                         select new
                         {
                             RoomName = r.room_name,
                             RoomCapacity = r.room_capacity,
                             LocationName = l.location_name,
                             Address = l.location_address,
                             ZipCode = l.location_zipcode
                         }).ToList();

            return JsonConvert.SerializeObject(query);
        }
    }
}
