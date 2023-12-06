using BackEnd.Model;
using BackEnd.Services;
using DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("produtoPedido")]
public class ProdutoPedidosController : ControllerBase
{
    [HttpPost("create")]
    [EnableCors("DefaultPolicy")]
    public async Task<IActionResult> Create(
        [FromBody] ProdutoPedidosData produtoPedido,
        [FromServices] IProdutoPedidosService service)
    {
        var errors = new List<string>();
        if (produtoPedido is null)
            errors.Add("É necessário informar um Pedido.");
        if (errors.Count > 0)
            return BadRequest(errors);

        await service.Create(produtoPedido.produtoId, produtoPedido.pedidoId);
        return Ok();
    }

    [HttpGet("getAll")]
    [EnableCors("DefaultPolicy")]
    public IActionResult GetAll(
            [FromServices] IProdutoPedidosService service
        )
    {
        var produtoPedidos = service.GetAll();

        return Ok(produtoPedidos);
    }

}