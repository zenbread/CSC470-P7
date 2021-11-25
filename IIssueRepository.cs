using System.Collections.Generic;

namespace P7
{
    interface IIssueRepository
    {
        string Add(Issue issue);
        List<Issue> GetAll(int ProjectId);
        bool Remove(Issue issue);
        string Modify(Issue issue);
        int GetTotalNumberOfIssues(int ProjectId);
        List<string> GetIssuesByMonth(int PorjectId);
        List<string> GetIssuesByDiscoverer(int ProjectId);
        Issue GetIssueById(int Id);
    }
}
