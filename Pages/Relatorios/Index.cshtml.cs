using Microsoft.AspNetCore.Mvc.RazorPages;
using Sistema_Logistico.Data;
using Sistema_Logistico.Models;

namespace Sistema_Logistico.Pages.Relatorios;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }
    public List<Produto> ProdutosCriticos { get; set; } = new();

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
        ProdutosCriticos = _context.Produtos.Where(p => p.QuantidadeEstoque < 10).ToList();
    }
}