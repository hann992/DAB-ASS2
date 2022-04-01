using Microsoft.AspNetCore.Mvc;

namespace DAB_ASS2.Controllers
{
    [ApiController]
    [Route("Societies/")]
    public class SocietiesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            // Samle info og sende retur...


            return "Retur";
        }
    }
}
