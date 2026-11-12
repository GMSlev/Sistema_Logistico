using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sistema_Logistico.Models;
using Sistema_Logistico.Data;

namespace Sistema_Logistico.Pages.FornecedorPages;

public class DeleteModel : PageModel
{
    private readonly AppDbContext _context;

    public DeleteModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Fornecedor Fornecedor { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var fornecedor = await _context.Fornecedores.FirstOrDefaultAsync(m => m.Id == id);
        if (fornecedor is null)
        {
            return NotFound();
        }
        else
        {
            Fornecedor = fornecedor;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var fornecedor = await _context.Fornecedores.FindAsync(id);
        if (fornecedor != null)
        {
            Fornecedor = fornecedor;
            _context.Fornecedores.Remove(Fornecedor);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
