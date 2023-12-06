using System.Threading.Tasks;

namespace BackEnd.Services;

using DTO;
using Model;

public interface IProdutoPedidosService
{
    Task Create(int IdProduto, int idPedido);
    List<ProdutoPedido> GetAll();
    Task Delete(ProdutoPedido produtoPedido);

}