using Microsoft.AspNetCore.Mvc;

namespace RelicTracker.Controllers
{
    [ApiController]
    public class RelicController : Controller
    {
        [HttpGet]
        public IActionResult GetRelics()
        {
            return View();
        }
    }
}
