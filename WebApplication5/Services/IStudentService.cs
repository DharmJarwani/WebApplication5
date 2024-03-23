using WebApplication5.Models;

namespace WebApplication5.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetStudentsAsync();
    }
}
