using System;

namespace DTO;

public class ProdutoData
{
    public string name { get; set; }
    public byte[] Imagem { get; set; }
    public double preco { get; set; }
    public string? descricao { get; set; }
    public double? promocao { get; set; }
    public string? descricaoPromocao { get; set; }
}