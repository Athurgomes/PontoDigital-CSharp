using Microsoft.EntityFrameworkCore;
using SistemaPonto.Models;

namespace SistemaPonto.Data;

public class PontoDbContext : DbContext
{
    public DbSet<PontoModels> Apontamentos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = registroPonto.db");
        base.OnConfiguring(optionsBuilder);
    }
}