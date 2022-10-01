using Microsoft.EntityFrameworkCore;

namespace WebApiEticaret.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-ROTCU0Q;Database=EticaretDemo;integrated security=true");
        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Sepet> Sepet { get; set; }

    }
}
