using BackEnd.Model;
using BackEnd.Services;
using DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("pedido")]
public class PedidoController : ControllerBase
{
    [HttpPost("create")]
    [EnableCors("DefaultPolicy")]
    public async Task<IActionResult> Create(
        [FromBody] PedidoData pedido,
        [FromServices] IPedidoService service)
    {
        var errors = new List<string>();
        if (pedido is null)
            errors.Add("É necessário informar um pedido.");
        if (errors.Count > 0)
            return BadRequest(errors);

        await service.Create(pedido);
        return Ok();
    }

    [HttpGet("getAll")]
    [EnableCors("DefaultPolicy")]
    public IActionResult GetAll(
            [FromServices] IPedidoService service
        )
    {
        var pedidos = service.GetAll();

        return Ok(pedidos);
    }

    // [HttpDelete("delete")]
    // [EnableCors("DefaultPolicy")]
    // public async Task<IActionResult> Delete(
    // [FromBody] PedidoData pedidoData,
    // [FromServices] IPedidoService pedidoService
    // ) 
    // {
    //     var order = pedidoService.GetPedidoById(pedidoData.name).Result;
    //     await pedidoService.Delete(order);
    //     return Ok();
    // }

}