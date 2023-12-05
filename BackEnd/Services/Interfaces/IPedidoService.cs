using System.Threading.Tasks;

namespace BackEnd.Services;

using DTO;
using Model;

public interface IPedidoService
{
    Task Create(PedidoData data);
    List<Pedido> GetAll();
    Task Delete(Pedido pedido);
    Task<Pedido> GetPedidoById(int id);
    Task<Pedido> GetPedidoByName(string name);
}