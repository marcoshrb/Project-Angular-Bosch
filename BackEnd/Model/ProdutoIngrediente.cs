using System;
using System.Collections.Generic;

namespace BackEnd.Model;

public partial class ProdutoIngrediente
{
    public int Id { get; set; }

    public int IngredientesId { get; set; }

    public int ProdutoId { get; set; }

    public virtual Ingrediente Ingredientes { get; set; } = null!;

    public virtual Produto Produto { get; set; } = null!;
}
