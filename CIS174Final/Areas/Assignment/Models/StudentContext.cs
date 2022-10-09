using Microsoft.EntityFrameworkCore;

namespace CIS174Final.Areas.Assignment.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
           : base(options)
        { }
        public DbSet<Student> TestStudents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
               new Student
               {
                   Id = 1,
                   FirstName = "Test1",
                   LastName = "Name1",
                   Grade = "10"
               },
               new Student
               {
                   Id = 2,
                   FirstName = "Test2",
                   LastName = "Name2",
                   Grade = "9"
               },
               new Student
               {
                   Id = 3,
                   FirstName = "Test3",
                   LastName = "Name3",
                   Grade = "5"
               },
               new Student
               {
                   Id = 4,
                   FirstName = "Test4",
                   LastName = "Name4",
                   Grade = "1"
               });
        }
    }
}
