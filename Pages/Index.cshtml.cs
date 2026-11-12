using Microsoft.AspNetCore.Mvc.RazorPages;
using Sistema_Logistico.Data;
using Sistema_Logistico.Models;

namespace Sistema_Logistico.Pages;

public class IndexModel : PageModel
{
    public List<Pedido> UltimosPedidos { get; set; } = new();
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public int TotalProdutos { get; set; }
    public int TotalFornecedores { get; set; }
    public int TotalPedidos { get; set; }
    public int TotalEntregas { get; set; }
    public int EstoqueCritico { get; set; }

    public void OnGet()
    {
        TotalProdutos = _context.Produtos.Count();
        TotalFornecedores = _context.Fornecedores.Count();
        TotalPedidos = _context.Pedidos.Count();
        TotalEntregas = _context.Entregas.Count();
        EstoqueCritico = _context.Produtos.Count(p => p.QuantidadeEstoque < 10);
        UltimosPedidos = _context.Pedidos.OrderByDescending(p => p.DataPedido).Take(5).ToList();
    }
}