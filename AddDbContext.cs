using Microsoft.EntityFrameworkCore;
using SchoolManagement.Data.Models;

namespace SchoolManagement.Data
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
