using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers;

using DTO;
using Microsoft.Identity.Client;
using Model;
using Services;
using Trevisharp.Security.Jwt;

[ApiController]
[Route("usuario")]
public class UsuarioController : ControllerBase
{
    

    [HttpPost("login")]
    [EnableCors("DefaultPolicy")]
    public async Task<IActionResult> Login(
        [FromBody]UsuarioData user,
        [FromServices]IUserService service,
        [FromServices]ISecurityService security,
        [FromServices]CryptoService crypto)
    {
        var loggedUser = await service.GetByLogin(user.name);
        
        if (loggedUser == null)
            return Unauthorized("Usuário não existe.");
        
        var password = await security.HashPassword(
            user.password, loggedUser.Salt
        );
        var realPassword = loggedUser.Senha;
        if (password != realPassword)
            return Unauthorized("Senha incorreta.");
        
        var jwt = crypto.GetToken(new {
            id = loggedUser.Id,
            isAdm = loggedUser.Adm
        });

        return Ok(new { jwt, loggedUser.Adm });
    }

    [HttpPost("register")]
    [EnableCors("DefaultPolicy")]
    public async Task<IActionResult> Create(
        [FromBody]UsuarioData user,
        [FromServices]IUserService service)
    {
        var errors = new List<string>();
        if (user is null || user.name is null)
            errors.Add("É necessário informar um login.");
        if (user.name.Length < 3)
            errors.Add("O Login deve conter ao menos 3 caracteres.");

        if (errors.Count > 0)
            return BadRequest(errors);

        await service.Create(user);
        return Ok();
    }

 
}
