using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb_759_Grupo1Q4.DTOs;
using ProyectoWeb_759_Grupo1Q4.Services;

namespace ProyectoWeb_759_Grupo1Q4.Controllers;


public class AuthControllerBiblioHub
{
[ApiController]
// api/Auth
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    // POST /api/Auth/register
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto dto)
    {
        try
        {
            var user = await _authService.Register(dto);
            return Ok(new
            {
                user.Email, user.Password, user.DisplayName, user.Username,
                user.PhoneNumber, user.BirthDate, user.Country, user.Bio
            });
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDTOs dto)
    {
        try
        {
            var token = await _authService.Login(dto);
            return Ok(new { token });
            return Ok(new
            {
                token.Email, token.Password
            });
        }
        catch (Exception e)
        {
            return BadRequest(new { message = e.Message });
        }
    }

}
}