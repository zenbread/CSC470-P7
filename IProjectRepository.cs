using System.Collections.Generic;

namespace P7
{
    public interface IProjectRepository
    {
        string Add(Project project, out int Id);
        List<Project> GetAll();
        string Remove(int projectId);
        string Modify(int projectId, Project project);
    }
}