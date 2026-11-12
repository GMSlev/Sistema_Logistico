using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sistema_Logistico.Models;
using Sistema_Logistico.Data;

namespace Sistema_Logistico.Pages.PedidoPages;

public class DeleteModel : PageModel
{
    private readonly AppDbContext _context;

    public DeleteModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Pedido Pedido { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var pedido = await _context.Pedidos.FirstOrDefaultAsync(m => m.Id == id);
        if (pedido is null)
        {
            return NotFound();
        }
        else
        {
            Pedido = pedido;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var pedido = await _context.Pedidos.FindAsync(id);
        if (pedido != null)
        {
            Pedido = pedido;
            _context.Pedidos.Remove(Pedido);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
