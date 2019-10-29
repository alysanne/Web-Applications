namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public enum Category
    {
        Deadline, WFH
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }


    public class Event
    {
        public int ID { get; set; }
        public Category CategoryID { get; set; }
        
//        public Category Category { get; set; }
    }
}

