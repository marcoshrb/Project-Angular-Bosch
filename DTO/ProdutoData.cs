using System;

namespace DTO;

public class ProdutoData
{
    public byte[] Imagem { get; set; }
    public string name { get; set; }
    public double preco { get; set; }
    public string? descricao { get; set; }
    public bool promocao { get; set; }
    public double? precoPromocao { get; set; }
    public string? cupom { get; set; }
    public string? descricaoPromocao { get; set; }
}