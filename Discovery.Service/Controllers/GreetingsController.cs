using Microsoft.AspNetCore.Mvc;

namespace Discovery.Service.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello Stranger";
        }
    }
}
