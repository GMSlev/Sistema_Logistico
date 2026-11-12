using System.ComponentModel.DataAnnotations;

namespace Sistema_Logistico.Models;

public class Pedido
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O cliente é obrigatório.")]
    [Display(Name = "Cliente")]
    public string Cliente { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Data do Pedido")]
    public DateTime DataPedido { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "O status é obrigatório.")]
    [Display(Name = "Status")]
    public string Status { get; set; } = "Pendente";

    [Display(Name = "Valor Total")]
    public decimal ValorTotal { get; set; }

    [Display(Name = "Observações")]
    public string? Observacao { get; set; }
}