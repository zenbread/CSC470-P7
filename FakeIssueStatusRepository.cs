using System.Collections.Generic;

namespace P6
{
    class FakeIssueStatusRepository : IIssueStatusRepository
    {
        public FakeIssueStatusRepository()
        {

            if (_IssueStatuses.Count == 0)
            {
                List<string> statuses = new List<string> {
                    "Open",
                    "Assigned",
                    "Fixed",
                    "Closed - Won't Fix",
                    "Closed - Fixed",
                    "Closed - by design",
                };
                int index = 0;
                foreach (string stat in statuses)
                {
                    Add(index++, stat);
                }
            }
        }
        private static List<IssueStatus> _IssueStatuses = new List<IssueStatus>();
        public void Add(int Id, string Value)
        {
            IssueStatus tmp = new IssueStatus() { Id = Id, Value = Value };
            _IssueStatuses.Add(tmp);
        }

        public List<IssueStatus> GetAll()
        {
            return _IssueStatuses;
        }

        public int GetIdByStatus(string value)
        {
            foreach (IssueStatus issue in _IssueStatuses)
            {
                if( issue.Value == value)
                {
                    return issue.Id;
                }
            }
            return -1;
        }

        public string GetValueById(int Id)
        {
            foreach (IssueStatus issue in _IssueStatuses)
            {
                if (issue.Id == Id)
                {
                    return issue.Value;
                }
            }
            return "";
        }
    }
}
