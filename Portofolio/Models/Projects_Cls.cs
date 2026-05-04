namespace Portofolio.Models
{
    public class Projects_Cls
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ProgrammingLanguage { get; set; }
        public string Category { get; set; }
        public string ? ImagePath  { get; set; }
    }
}
