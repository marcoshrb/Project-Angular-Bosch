
using BackEnd.Model;
using BackEnd.Services;
using DTO;
using Microsoft.EntityFrameworkCore;

public class ProdutoService: IProdutoService
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
}
