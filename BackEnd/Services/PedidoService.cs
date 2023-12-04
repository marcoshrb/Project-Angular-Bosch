
using BackEnd.Model;
using BackEnd.Services;
using DTO;
using Microsoft.EntityFrameworkCore;

public class PedidoService: IPedidoService
{
    VascoContext ctx;

    public PedidoService(VascoContext ctx)
    {
        this.ctx = ctx;
    }

    public async Task Create(PedidoData data)
    {
        Pedido pedido = new Pedido();

        
        pedido.Nome = data.name;
        pedido.Total = data.total;
        pedido.Entregue = data.entregue;

        this.ctx.Add(pedido);
        await this.ctx.SaveChangesAsync();
    }

    public List<Pedido> GetAll()
    {
        return ctx.Pedidos.ToList();
    }
}
