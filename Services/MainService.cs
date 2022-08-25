using Portfalio.Data;
using Portfalio.Models;
using Portfalio.Service;

namespace Portfalio.Services
{
    public class MainService : IMainService
    {
        private readonly ApplicationDbContext db;

        public MainService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddProject(Project project)
        {
            db.Project.Add(project);
            db.SaveChanges();
        }

        public void DeleteProject(Project project)
        {
            db.Project.Remove(project);
            db.SaveChanges();
        }


        public List<Project> GetAllProject()
        {
            return db.Project.ToList();
        }

        public Project GetProjectById(int id)
        {
            return db.Project.Find(id);
        }

        public void UpdateProject(Project project)
        {
            db.Project.Update(project);
            db.SaveChanges();
        }
    }
}
