using Microsoft.AspNetCore.Mvc;
using Portfalio.Models;
using Portfalio.Service;

namespace Portfalio.Controllers
{
    public class ProjectsController : Controller

    {
        private readonly IMainService mainService;

        public ProjectsController(IMainService mainService)
        {
            this.mainService = mainService;
        }

         
       

        public IActionResult Projects()
        { 
            var data = mainService.GetAllProject();
             
            return View(data);
        }

        public IActionResult AddProject()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddProject(Project project)
        {
             mainService.AddProject(project);
            TempData["success"] = "New Project Added SuccessFully";
             return RedirectToAction(actionName: "Projects", controllerName: "Projects");
        }


        public IActionResult EditProject(int? id)
        {
            var project = mainService.GetProjectById((int)id);
            return View(project);
        }

        [HttpPost]
        public IActionResult EditProject(Project project)
        {
            //mainService.AddProject(project);
            mainService.UpdateProject(project);
            TempData["success"] = "Project SuccessFully Edited";
            return RedirectToAction(actionName: "Projects", controllerName: "Projects");
        }


        public IActionResult DeleteProject(int? id)
        {
            var project = mainService.GetProjectById((int)id);

            return View(project);
        }

        [HttpPost]
        public IActionResult DeleteProject(Project project)
        {
            //mainService.AddProject(project);
            mainService.DeleteProject(project);
            TempData["success"] = "Project Deleted!";
            return RedirectToAction(actionName: "Projects", controllerName: "Projects");
        }



    }
}
