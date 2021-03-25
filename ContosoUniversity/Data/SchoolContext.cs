using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Course>().ToTable("Course");
            builder.Entity<Enrollment>().ToTable("Enrollment");
            builder.Entity<Student>().ToTable("Student");
        }
    }
}
