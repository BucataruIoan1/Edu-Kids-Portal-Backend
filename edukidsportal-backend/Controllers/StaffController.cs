using edukidsportal_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace edukidsportal_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var staff = await _staffService.GetAllAsync();
            return Ok(staff);
        }
    }
}
