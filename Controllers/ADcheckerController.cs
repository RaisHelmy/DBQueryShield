using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ADchecker.Controllers
{

    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ADcheckerController : Controller
    {
        [HttpGet]
        public IActionResult Get([FromHeader] int Name)
        {
            //use Name
            Console.WriteLine($"Receiving Userinfo: {Name}");

            return Ok();
        }
    }
}
