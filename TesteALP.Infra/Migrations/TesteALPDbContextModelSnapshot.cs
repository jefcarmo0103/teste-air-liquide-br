﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteALP.Infra.Context;

namespace TesteALP.Infra.Migrations
{
    [DbContext(typeof(TesteALPDbContext))]
    partial class TesteALPDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteALB.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("CriadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Excluido")
                        .HasColumnType("bit");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModificadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModificadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
