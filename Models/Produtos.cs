using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Logistico.Models;

public class Produto
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Categoria { get; set; } = string.Empty;

    public int QuantidadeEstoque { get; set; }

    [Precision(18, 2)]
    public decimal Preco { get; set; }
}
