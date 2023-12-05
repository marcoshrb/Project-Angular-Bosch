
using BackEnd.Model;
using BackEnd.Services;
using DTO;
using Microsoft.EntityFrameworkCore;

public class PedidoProdutoService: IPedidoProdutoService
{
    VascoContext ctx;

    public PedidoProdutoService(VascoContext ctx)
    {
        this.ctx = ctx;
    }

    // public async Task Create(PedidoProdutoData data, Produto produto)
    // {
    //     PedidoProdutoData pedido = new PedidoProdutoData();
        
    //     pedido.Nome = data.name;
    //     pedido.Total = data.total;
    //     pedido.Entregue = data.entregue;

    //     this.ctx.Add(pedido);
    //     await this.ctx.SaveChangesAsync();
    // }

    public async Task<List<Pedido>> GetAll()
    {
        return await ctx.Pedidos.ToListAsync();
    }

    public async Task Delete(Pedido pedido){
        this.ctx.Remove(pedido);
        await this.ctx.SaveChangesAsync();
    }

    public Task<Pedido> GetPedidoByName(string name)
    {
        throw new NotImplementedException();

        //        var query =
        //     from pedido in this.ctx.Pedidos
        //     where pedido.Usuario == id
        //     select pedido;

        // return await query.FirstOrDefaultAsync();
    }
}
