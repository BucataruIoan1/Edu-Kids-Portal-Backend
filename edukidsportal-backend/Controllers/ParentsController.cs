using edukidsportal_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace edukidsportal_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParentsController : ControllerBase
    {
        private readonly IParentService _parentService;

        public ParentsController(IParentService parentService)
        {
            _parentService = parentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var parents = await _parentService.GetAllAsync();
            return Ok(parents);
        }
    }
}
