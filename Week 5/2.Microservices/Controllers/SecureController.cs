using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecureController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetSecureData()
        {
            return Ok("You have accessed a secure endpoint!");
        }
    }
}