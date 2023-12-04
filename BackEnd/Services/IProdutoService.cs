using System.Threading.Tasks;

namespace BackEnd.Services;

using DTO;
using Model;

public interface IProdutoService
{
    Task Create(ProdutoData data);
}