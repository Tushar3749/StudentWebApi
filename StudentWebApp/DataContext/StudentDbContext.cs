using Microsoft.EntityFrameworkCore;
using StudentWebApp.Models;

namespace StudentWebApp.DataContext
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext>options)
            :base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
