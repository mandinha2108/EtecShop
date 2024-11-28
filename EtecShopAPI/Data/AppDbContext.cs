using EtecShopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EtecShopAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Categoria> Categorias { set; get; }
    public DbSet<Produto> Produtos { set; get; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}