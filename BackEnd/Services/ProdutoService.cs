
using BackEnd.Model;
using BackEnd.Services;
using DTO;
using Microsoft.EntityFrameworkCore;

public class ProdutoService : IProdutoService
{
    VascoContext ctx;

    public ProdutoService(VascoContext ctx)
    {
        this.ctx = ctx;
    }

    public async Task Create(ProdutoData data)
    {
        double numero = data.preco;
        string numeroFormatado = numero.ToString("0.00");

        Produto produto = new Produto();

        produto.Imagem = data.Imagem;
        produto.Nome = data.name;
        produto.Preco = numeroFormatado;
        produto.Descricao = data.descricao;
        produto.Promocao = data.promocao;
        produto.PrecoPromocao = data.precoPromocao;
        produto.Cupom = data.cupom;
        produto.DescricaoPromocao = data.descricaoPromocao;

        this.ctx.Add(produto);
        await this.ctx.SaveChangesAsync();
    }

    public List<Produto> GetAll()
    {
        return ctx.Produtos.ToList();
    }

    public async Task<Produto> GetProdutobyId(int id)
    {

        var query =
            from u in this.ctx.Produtos
            where u.Id == id
            select u;

        return await query.FirstOrDefaultAsync();
    }

    public async Task Update(ProdutoData data, int id)
    {
        var query =
            from u in this.ctx.Produtos
            where u.Id == id
            select u;

        var product = await query.FirstOrDefaultAsync();


        if (product != null)
        {
            product.Imagem = data.Imagem;
            product.Nome = data.name;
            product.Preco = data.preco.ToString("0.00");
            product.Descricao = data.descricao;
            product.Promocao = data.promocao;
            product.PrecoPromocao = data.precoPromocao;
            product.Cupom = data.cupom;
            product.DescricaoPromocao = data.descricaoPromocao;

            this.ctx.Update(product);

            await this.ctx.SaveChangesAsync();
        }
        else {
            
        }
    }

}
