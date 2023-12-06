
using System.Data;
using BackEnd.Model;
using BackEnd.Services;
using DTO;

using Microsoft.EntityFrameworkCore;

public class ProdutoPedidosService: IProdutoPedidosService
{
    VascoContext ctx;

    public ProdutoPedidosService(VascoContext ctx)
    {
        this.ctx = ctx;
    }

    public async Task Create(int idProduto, int idPedido)
    {
        ProdutoPedido produtoPedido = new ProdutoPedido();

    
        var queryidPedido =
            from pedido in this.ctx.Pedidos
            where pedido.Id == idPedido
            select pedido;

        var PedidoFirst = await queryidPedido.FirstOrDefaultAsync();

        var queryidProduto =
            from produto in this.ctx.Produtos
            where produto.Id == idProduto
            select produto;

        var ProdutoFirst = await queryidProduto.FirstOrDefaultAsync();

        produtoPedido.ProdutoId = idProduto;
        produtoPedido.PedidoId = idPedido;
        produtoPedido.Pedido = PedidoFirst;
        produtoPedido.Produto = ProdutoFirst;

        this.ctx.Add(produtoPedido);
        await this.ctx.SaveChangesAsync();
    }
    public List<ProdutoPedido> GetAll()
    {
        return ctx.ProdutoPedidos.ToList();
    }

    public async Task Delete(ProdutoPedido produtoPedido)
    {
        this.ctx.Remove(produtoPedido);
        await this.ctx.SaveChangesAsync();
    }
}
