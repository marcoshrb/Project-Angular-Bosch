using BackEnd.Model;
using BackEnd.Services;
using DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("produto")]
public class ProdutoController : ControllerBase
{
        [HttpPost("create")]
        [EnableCors("DefaultPolicy")]
        public async Task<IActionResult> Create(
            [FromBody] ProdutoData produto,
            [FromServices] IProdutoService service)
            {
                var errors = new List<string>();
                if(produto is null)
                    errors.Add("É necessário informar um produto.");
                if(errors.Count > 0)
                    return BadRequest(errors);

                await service.Create(produto);
                return Ok();
            }

        [HttpGet("getAll")]
        [EnableCors("DefaultPolicy")]
        public IActionResult GetAll(
            [FromServices] IProdutoService service
        )
        {
            var produtos = service.GetAll(); 

            return Ok(produtos);
        }
       
}