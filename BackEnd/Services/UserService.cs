using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BackEnd.Services;

using DTO;
using Model;

public class UserService : IUserService
{
    VascoContext ctx;
    ISecurityService security;
    public UserService(VascoContext ctx, ISecurityService security)
    {
        this.ctx = ctx;
        this.security = security;
    }

    public async Task Create(UsuarioData data)
    {
        Usuario usuario = new Usuario();
        var salt = await security.GenerateSalt();

        usuario.Nome = data.name;
        usuario.Adm = data.adm;
        usuario.Senha = await security.HashPassword(
            data.password, salt
        );
        usuario.Salt = salt;

        this.ctx.Add(usuario);
        await this.ctx.SaveChangesAsync();
    }

    public async Task<Usuario> GetByLogin(string login)
    {
        var query =
            from u in this.ctx.Usuarios
            where u.Nome == login
            select u;
        
        return await query.FirstOrDefaultAsync();
    }

    
}