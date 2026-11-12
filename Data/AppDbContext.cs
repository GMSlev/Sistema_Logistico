using Microsoft.EntityFrameworkCore;
using Sistema_Logistico.Models;

namespace Sistema_Logistico.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Fornecedor> Fornecedores { get; set; }

    public DbSet<Pedido> Pedidos { get; set; }

    public DbSet<Entrega> Entregas { get; set; }
}