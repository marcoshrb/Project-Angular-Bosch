
using System.Data;
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
        var hora = DateTime.Now;

        Pedido pedido = new Pedido();
        
        
        pedido.Nome = data.name;
        pedido.Total = data.total;
        pedido.Hora = hora;
        pedido.Entregue = data.entregue;

        this.ctx.Add(pedido);
        await this.ctx.SaveChangesAsync();
    }

   public List<Pedido> GetAll()
    {
        return ctx.Pedidos.ToList();
    }

    public async Task Delete(Pedido pedido){
        this.ctx.Remove(pedido);
        await this.ctx.SaveChangesAsync();
    }

    public async Task<Pedido> GetPedidoById(int id)
    {
        var query =
            from pedido in this.ctx.Pedidos
            where pedido.Id == id
            select pedido;

        return await query.FirstOrDefaultAsync();
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
