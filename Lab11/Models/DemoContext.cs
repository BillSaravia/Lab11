using Microsoft.EntityFrameworkCore;

namespace Lab11.Models
{
    public class DemoContext : DbContext
    {

        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Course { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Student> Student { get; set; }

    }
}