
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
        Pedido produto = new Pedido();

        
        produto.Nome = data.name;
        produto.Total = data.total;
        produto.Entregue = data.entregue;

        this.ctx.Add(produto);
        await this.ctx.SaveChangesAsync();
    }

    public List<Pedido> GetAll()
    {
        throw new NotImplementedException();
    }
}
