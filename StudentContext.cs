using Microsoft.EntityFrameworkCore;
using StudentMVC.Models;

namespace StudentMVC.Data
{
    public class StudentContext : DbContext
    {

        public StudentContext (DbContextOptions<StudentContext> options):base(options)
        { }

        public DbSet<Student> Students { get; set; }
    }
}
