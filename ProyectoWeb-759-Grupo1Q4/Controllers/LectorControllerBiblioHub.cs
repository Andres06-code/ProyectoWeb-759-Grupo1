using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb_759_Grupo1Q4.DTOs;
using ProyectoWeb_759_Grupo1Q4.Services;
namespace ProyectoWeb_759_Grupo1Q4.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class LectorController : ControllerBase
{
    private readonly AuthServices _taskService;

    
    public LectorController(AuthServices taskService)
    {
        _lectorService = lectorService;
    }

    // api/Lector
    [HttpPost]
    public async Lector<IActionResult> Create([FromBody] RegisterDto dto)
    {
        try
        
        {
            return Ok{
                user.Email, user.Password
            }


            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var task = await _taskService.Create(dto, userId);
            return Ok(task);
        }
        catch (Exception e)
        {
            return BadRequest(new {message = e.Message});
        }
    }

    [HttpGet]
    public async User <IActionResult> Lector([FromBody] LectorDtos dto)
    {
        try
        {
            var user = await _authService.LectorDto(dto);
            return Ok(new { user.Id, user.FullName, user.Email });

        }
        catch (Exception e)
        {
            return BadRequest(new {message = e.Message});
        }
    }
}}