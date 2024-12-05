using Microsoft.EntityFrameworkCore;

namespace InsurgencyAPI.Models;

public class AppDataContext : DbContext
{
    
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Classe> Classes { get; set; }
    public DbSet<Inventario> Inventarios { get; set; }
    public DbSet<Item> Itens { get; set; }
    public DbSet<Arma> Armas { get; set; }
    public DbSet<Equipamento> Equipamentos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Gridlock.db");
    }
}