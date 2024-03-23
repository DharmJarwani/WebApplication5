using WebApplication5.Models;
using WebApplication5.Repositories;

namespace IntegrationTests
{
    public class MockStudentRepository : IStudentRepository
    {
        private readonly List<Student> _students;

        public MockStudentRepository()
        {
            // Initialize the list of students with test data
            _students = new List<Student>
            {
                new Student { Id = 1, Name = "John", Age = 20 },
                new Student { Id = 2, Name = "Alice", Age = 22 },
                // Add more test data as needed
            };
        }

        public Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return Task.FromResult<IEnumerable<Student>>(_students);
        }
    }
}
