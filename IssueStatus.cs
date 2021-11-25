namespace P6
{
    class IssueStatus
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}
