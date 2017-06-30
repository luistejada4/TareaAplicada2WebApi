using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TareaAplicada.DAL;

namespace TareaAplicada.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TareaAplicada.Models.Cobro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Fecha");

                    b.Property<int>("IdRemoto");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitud");

                    b.Property<double>("Monto");

                    b.Property<double>("Mora");

                    b.Property<string>("Referencia");

                    b.Property<int>("esNulo");

                    b.HasKey("Id");

                    b.ToTable("Cobros");
                });
        }
    }
}
