
using BackEnd.Model;
using BackEnd.Services;
using DTO;

public class ProdutoService: IProdutoService
{
    VascoContext ctx;

    public ProdutoService(VascoContext ctx)
    {
        this.ctx = ctx;
    }

    public async Task Create(ProdutoData data)
    {
        Produto produto = new Produto();

        produto.Imagem = data.Imagem;
        produto.Nome = data.name;
        produto.Preco = data.preco;
        produto.Descricao = data.descricao;
        produto.Promocao = data.promocao;
        produto.PrecoPromocao = data.precoPromocao;
        produto.Cupom = data.cupom;
        produto.DescricaoPromocao = data.descricaoPromocao;

        this.ctx.Add(produto);
        await this.ctx.SaveChangesAsync();
    }
}
