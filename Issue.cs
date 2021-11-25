using System;

namespace P6
{
    public class Issue
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public DateTime DiscoveryDate { get; set; }
        public string Discoverer { get; set; }
        public string InitialDescription { get; set; }
        public string Component { get; set; }
        public int IssueStatusId { get; set; }
    }
}
