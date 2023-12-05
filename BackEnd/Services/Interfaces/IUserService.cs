using System.Threading.Tasks;

namespace BackEnd.Services;

using DTO;
using Model;

public interface IUserService
{
    Task Create(UsuarioData data);
    Task<Usuario> GetByLogin(string login);

}