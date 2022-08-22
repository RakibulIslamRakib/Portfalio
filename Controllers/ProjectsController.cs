using Microsoft.AspNetCore.Mvc;

namespace Portfalio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult projects()
        {
            return View();
        }

        public IActionResult projectsDetails()
        {
            return View();
        }
    }
}
