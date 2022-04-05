using Microsoft.AspNetCore.Mvc;

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

            return "Retur";
        }
    }
}
