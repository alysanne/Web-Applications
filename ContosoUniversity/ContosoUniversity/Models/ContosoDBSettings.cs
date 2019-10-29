namespace ContosoUniversity.Models
{
    public class ContosoDBSettings : IContosoDBSettings
    {
        public string StudentsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    
    public interface IContosoDBSettings
    {
        string StudentsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
