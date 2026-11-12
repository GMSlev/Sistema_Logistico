using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sistema_Logistico.Models;
using Sistema_Logistico.Data;

namespace Sistema_Logistico.Pages.FornecedorPages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<Fornecedor> Fornecedor { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Fornecedor = await _context.Fornecedores.ToListAsync();
    }
}
