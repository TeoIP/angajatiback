using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DenumiriController : ControllerBase
    {
        [HttpGet("getAllDenumiri")]
        public IActionResult GetAllDenumiri()
        {
            var WorkPoint = new List<string> { "base unit 1", "base unit 2", "base unit 3" };
            return Ok(WorkPoint);
        }
    }
}
