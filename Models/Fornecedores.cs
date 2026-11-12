using System.ComponentModel.DataAnnotations;

namespace Sistema_Logistico.Models;

public class Fornecedor
{
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; } = string.Empty;

    public string Telefone { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;
}