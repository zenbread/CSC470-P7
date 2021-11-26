namespace P7
{
    public class Feature
    {
        public int Id { get; set; }
        [System.ComponentModel.Browsable(false)]
        public int ProjectId { get; set; }
        public string Title { get; set; }
    }
}
