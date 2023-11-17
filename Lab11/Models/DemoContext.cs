using Microsoft.EntityFrameworkCore;

namespace Lab11.Models
{
    public class DemoContext : DbContext
    {

        public DbSet<Course> Course { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1504-11\\SQLEXPRESS;Database=DemoDB;Trusted_Connection=True;");
        }

    }
}