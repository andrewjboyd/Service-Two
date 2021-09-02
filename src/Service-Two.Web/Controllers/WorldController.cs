using Microsoft.AspNetCore.Mvc;

namespace Service_Two.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorldController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "World!";
        }
    }
}
