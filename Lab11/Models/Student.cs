namespace Lab11.Models
{
    public class Student
    {

        public int StudentId { get; set; }



        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Phone { get; set; }

        public string Email { get; set; }

        public bool Activo { get; set; }

        //Grade

        public int GradeId { get; set; }
        public Grade Grade { get; set; }   



    }
}
