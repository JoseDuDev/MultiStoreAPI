using Microsoft.EntityFrameworkCore;
using MultiStoreAPI.Domain.Models;

namespace MultiStoreAPI.Domain.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("multiloja_db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Loja> Lojas { get; set; }
        public DbSet<LayoutConfig> LayoutConfigs { get; set; }
        //public DbSet<Produto> Produtos { get; set; }
    }
}
