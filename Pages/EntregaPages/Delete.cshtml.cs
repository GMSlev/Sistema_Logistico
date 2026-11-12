using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sistema_Logistico.Models;
using Sistema_Logistico.Data;

namespace Sistema_Logistico.Pages.EntregaPages;

public class DeleteModel : PageModel
{
    private readonly AppDbContext _context;

    public DeleteModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Entrega Entrega { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var entrega = await _context.Entregas.FirstOrDefaultAsync(m => m.Id == id);
        if (entrega is null)
        {
            return NotFound();
        }
        else
        {
            Entrega = entrega;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var entrega = await _context.Entregas.FindAsync(id);
        if (entrega != null)
        {
            Entrega = entrega;
            _context.Entregas.Remove(Entrega);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
