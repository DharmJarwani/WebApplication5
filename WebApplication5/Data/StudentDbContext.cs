using WebApplication5.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
