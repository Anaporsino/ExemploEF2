using ExemploEF.Models;
using Microsoft.EntityFrameworkCore;

namespace ExemploEF.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        {
        }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Categoria>().ToTable("Categorias");

        }
        public DbSet<ExemploEF.Models.Categoria> Categoria { get; set; } = default!;
        public DbSet<ExemploEF.Models.Produto> Produto { get; set; } = default!;

    }

}

