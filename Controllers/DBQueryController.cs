using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DBQuery.Controllers
{

    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class DBQueryController : Controller
    {
        [HttpGet]
        public IActionResult Get([FromHeader] int testId)
        {
            //use testId
            Console.WriteLine($"Receiving Userinfo: {testId}");

            return Ok();
        }
    }
}
