using System;
using System.Collections.Generic;

namespace BackEnd.Model;

public partial class Ofertum
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int? ProdutoId { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual Produto? Produto { get; set; }
}
