using System.Threading.Tasks;

namespace BackEnd.Services;

using DTO;
using Model;

public interface IProdutoService
{
    Task Create(ProdutoData data);

    List<Produto> GetAll();
    Task<Produto> GetProdutobyId(int id);

    Task Update(ProdutoData data, int id);
}