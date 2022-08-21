using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Portfalio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}