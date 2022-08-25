using Portfalio.Models;

namespace Portfalio.Service
{
    public interface IMainService
    {
        public List<Project> GetAllProject();
        public void AddProject(Project project);  
        public Project GetProjectById(int id);
        public void UpdateProject(Project project);
        public void DeleteProject(Project project);
    }
}
