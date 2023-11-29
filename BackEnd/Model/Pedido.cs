using System;
using System.Collections.Generic;

namespace BackEnd.Model;

public partial class Pedido
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public double? Total { get; set; }

    public bool Entregue { get; set; }

    public virtual ICollection<ProdutoPedido> ProdutoPedidos { get; } = new List<ProdutoPedido>();
}
