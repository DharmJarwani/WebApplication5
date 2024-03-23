using WebApplication5.Models;

namespace WebApplication5.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetStudentsAsync();
    }
}
