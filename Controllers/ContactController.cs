using Microsoft.AspNetCore.Mvc;

namespace Portfalio.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult contact()
        {
            return View();
        }
    }
}
