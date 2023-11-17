namespace Lab11.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public DateTime date { get; set; } 

        //Student
        public int IdStudent { get; set; }
        public Student Student { get; set; }

        //Course

        public int CourseId { get; set;}

        public Course Course { get; set; }

        }
}
