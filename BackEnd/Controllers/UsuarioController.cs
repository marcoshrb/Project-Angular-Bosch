using BackEnd.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controller;

[ApiController]
[Route("usuario")]
public class UsuarioController : ControllerBase
{
    [HttpPost("login")]
    [EnableCors("DefaultPolicy")]
    public async Task<IActionResult> Login(
        [FromBody]UsuarioData usuario,
        [FromServices]IUserService service,
        [FromServices]ISecurityService security
    )
}