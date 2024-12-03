using Microsoft.EntityFrameworkCore;

namespace InsurgencyAPI.Models;

public class AppDataContext : DbContext
{
    
    public DbSet<Card> Cards { get; set; }
    public DbSet<Tipo> Tipos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Ecommerce.db");
    }
}