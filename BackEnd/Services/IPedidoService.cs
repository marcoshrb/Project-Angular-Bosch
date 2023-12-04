using System.Threading.Tasks;

namespace BackEnd.Services;

using DTO;
using Model;

public interface IPedidoService
{
    Task Create(PedidoData data);

    List<Pedido> GetAll();
}