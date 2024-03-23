using WebApplication5.Models;
using WebApplication5.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            IEnumerable<Student> students = await _studentService.GetStudentsAsync();
            return Ok(students);
        }
    }
}
