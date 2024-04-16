using Lab_6.Data;
using Microsoft.AspNetCore.Mvc;

namespace Lab_6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private readonly FinanceDbContext _context;

        public DataController(FinanceDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUserData()
        {
            try
            {
                var users = _context.Users.ToList();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
