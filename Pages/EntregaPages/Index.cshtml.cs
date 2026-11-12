using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sistema_Logistico.Models;
using Sistema_Logistico.Data;

namespace Sistema_Logistico.Pages.EntregaPages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<Entrega> Entrega { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Entrega = await _context.Entregas.ToListAsync();
    }
}
