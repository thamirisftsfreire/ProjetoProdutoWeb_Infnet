using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using ProductWeb.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWeb.Migrations
{

    [DbContext(typeof(ProdutoContext))]
    partial class ProdutoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductWeb.Models.Produto", b =>
            {
                b.Property<Int32>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Nome");

                b.Property<string>("Fabricante");

                b.Property<string>("CodigoBarras");
                b.Property<Decimal>("Preco");
                b.Property<Int32>("Estoque");

                b.HasKey("Id");

                b.ToTable("Produtos");
            });

           
#pragma warning restore 612, 618
        }
    }
}
