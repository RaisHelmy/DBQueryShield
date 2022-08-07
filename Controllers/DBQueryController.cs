using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DBQuery.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class DBQueryController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync(string Query)
        {
            var servicesParam = new string[] { "jpjic", "jpn", "jpj", "orangdkhd", "oranghilang", "kenderaanhilang", "personal", "saman", "jim" };
            string? dbqueryresult = null;
            Console.WriteLine($"Receiving Userinfo: UserTest Querying for {Query}");
            var url = "http://10.32.8.204:3000";
            foreach (var param in servicesParam)
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Add("servicesParam", param);
                client.DefaultRequestHeaders.Add("searchParam", $"{Query}");
                var res = await client.GetStringAsync(url);
                dbqueryresult += res;
            }
            return Ok(dbqueryresult);
        }
    }
}
