using System.Threading.Tasks;
using Discovery.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Discovery.UI.Controllers 
{
    public class HomeController : Controller 
    {
        private readonly IGreetingsService _greetingsService;

        public HomeController(IGreetingsService greetingsService)
        {
            _greetingsService = greetingsService;
        }

        public async Task<IActionResult> Index() 
        {
            ViewData["GreetingsMessage"] = await _greetingsService.GetGreetingsMessage();

            return View();
        }
    }
}
