using edukidsportal_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace edukidsportal_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var students = await _studentService.GetAllAsync();
            return Ok(students);
        }
    }
}
