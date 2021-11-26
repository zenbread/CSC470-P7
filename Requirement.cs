namespace P7
{
    public class Requirement
    {
        public int Id;
        [System.ComponentModel.Browsable(false)]
        public int ProjectId;
        [System.ComponentModel.Browsable(false)]
        public int FeatureId;
        public string Statement;
    }
}
