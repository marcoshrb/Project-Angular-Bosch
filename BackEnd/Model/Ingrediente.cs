using System;
using System.Collections.Generic;

namespace BackEnd.Model;

public partial class Ingrediente
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<ProdutoIngrediente> ProdutoIngredientes { get; } = new List<ProdutoIngrediente>();
}
