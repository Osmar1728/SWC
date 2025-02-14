using Microsoft.AspNetCore.Mvc;
using SHA.Domain.DTO;
using SHA.Services.IServices;

namespace SHA.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService auth) : Controller
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserDTO loginDto)
        {
            var response = await auth.IniciarSesionAsync(loginDto.User, loginDto.Password);

            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
