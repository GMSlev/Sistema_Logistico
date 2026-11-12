using System.ComponentModel.DataAnnotations;

namespace Sistema_Logistico.Models;

public class Entrega
{
    public int Id { get; set; }

    [Required]
    public string Destino { get; set; } = string.Empty;

    [Required]
    public DateTime DataEntrega { get; set; }

    [Required]
    public string Status { get; set; } = "Em Transporte";

    public string Motorista { get; set; } = string.Empty;

    public string Veiculo { get; set; } = string.Empty;
}