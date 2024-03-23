using WebApplication5.Data;
using WebApplication5.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;

        public StudentRepository(StudentDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
