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
        //public async Task<IActionResult> GetAsync([FromHeader] string Name, [FromHeader] string Password, string Query)
        public async Task<IActionResult> GetAsync(string Query)
        {
            //use Name
            //Console.WriteLine($"Receiving Userinfo: {Name} Querying for {Query}");
            Console.WriteLine($"Receiving Userinfo: Test Querying for {Query}");
            /* var url = "http://10.32.8.204:3000";
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("servicesParam", "jpjic, jpn, jpj, orangdkhd, oranghilang, kenderaanhilang, personal, saman, jim");
            client.DefaultRequestHeaders.Add("searchParam", $"{Query}");
            var res = await client.GetStringAsync(url);
            Console.WriteLine(res); */
            return Ok("test");
        }
    }
}
