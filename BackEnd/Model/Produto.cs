using System;
using System.Collections.Generic;

namespace BackEnd.Model;

public partial class Produto
{
    public int Id { get; set; }


    public string Nome { get; set; } = null!;

    public double Preco { get; set; }

    public string Descricao { get; set; } = null!;

    public bool Promocao { get; set; }
    public byte[]? Imagem { get; set; }

    public double? PrecoPromocao { get; set; }

    public string? Cupom { get; set; }

    public string? DescricaoPromocao { get; set; }

    public virtual ICollection<Ofertum> Oferta { get; } = new List<Ofertum>();

    public virtual ICollection<ProdutoPedido> ProdutoPedidos { get; } = new List<ProdutoPedido>();
}
