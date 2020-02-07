using Microsoft.EntityFrameworkCore;
using ProductWeb.EntitiesConfiguration;
using ProductWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWeb.Context
{
    public class ProdutoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public ProdutoContext()
        {

        }
        public ProdutoContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=produtoDB;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProdutoConfig());           
        }
    }
}
