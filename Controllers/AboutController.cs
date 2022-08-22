using Microsoft.AspNetCore.Mvc;

namespace Portfalio.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
