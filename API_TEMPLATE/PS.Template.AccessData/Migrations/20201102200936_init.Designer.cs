﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PS.Template.AccessData.Context;

namespace PS.Template.AccessData.Migrations
{
    [DbContext(typeof(DbAutenticacionContext))]
    [Migration("20201102200936_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PS.Template.Domain.Entities.Cuenta", b =>
                {
                    b.Property<int>("IdCuenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FecAlta")
                        .HasColumnType("datetime");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoCuenta")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("IdCuenta")
                        .HasName("PK__Cuenta__D41FD70632A42B05");

                    b.HasIndex("IdEstado");

                    b.HasIndex("IdTipoCuenta");

                    b.ToTable("Cuenta");
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.Estado", b =>
                {
                    b.Property<int>("IdEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescEstado")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdEstado")
                        .HasName("PK__Estado__FBB0EDC12929C298");

                    b.ToTable("Estado");

                    b.HasData(
                        new
                        {
                            IdEstado = 1,
                            DescEstado = "Alta"
                        },
                        new
                        {
                            IdEstado = 2,
                            DescEstado = "Baja"
                        });
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.TipoCuenta", b =>
                {
                    b.Property<int>("IdTipoCuenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescTipCuenta")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdTipoCuenta")
                        .HasName("PK__TipoCuen__9CCA28505748AB74");

                    b.ToTable("TipoCuenta");

                    b.HasData(
                        new
                        {
                            IdTipoCuenta = 1,
                            DescTipCuenta = "Usuario"
                        },
                        new
                        {
                            IdTipoCuenta = 2,
                            DescTipCuenta = "Admin"
                        });
                });

            modelBuilder.Entity("PS.Template.Domain.Entities.Cuenta", b =>
                {
                    b.HasOne("PS.Template.Domain.Entities.Estado", "IdEstadoNavigation")
                        .WithMany("Cuenta")
                        .HasForeignKey("IdEstado")
                        .HasConstraintName("FK_Cuenta_Estado")
                        .IsRequired();

                    b.HasOne("PS.Template.Domain.Entities.TipoCuenta", "IdTipoCuentaNavigation")
                        .WithMany("Cuenta")
                        .HasForeignKey("IdTipoCuenta")
                        .HasConstraintName("FK_Cuenta_TipoCuenta")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
