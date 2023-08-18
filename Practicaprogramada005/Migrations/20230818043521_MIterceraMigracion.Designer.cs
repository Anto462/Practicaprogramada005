﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practicaprogramada005.Models;

#nullable disable

namespace Practicaprogramada005.Migrations
{
    [DbContext(typeof(pract05Context))]
    [Migration("20230818043521_MIterceraMigracion")]
    partial class MIterceraMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Practicaprogramada005.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resindencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Practicaprogramada005.Models.Servicio", b =>
                {
                    b.Property<int>("ServiciosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ServiciosID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiciosId"), 1L, 1);

                    b.Property<int>("Costo")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nombre");

                    b.HasKey("ServiciosId")
                        .HasName("PK__Servicio__ED7749BA09E86233");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Practicaprogramada005.Models.Solicitude", b =>
                {
                    b.Property<int>("SolicitudesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SolicitudesID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SolicitudesId"), 1L, 1);

                    b.Property<string>("Datsauto1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Datsauto2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Datsauto3")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Datsauto4")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Estadode")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("estadode");

                    b.Property<string>("Idusuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("IDUSUARIO");

                    b.Property<string>("Mecanico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiciosId")
                        .HasColumnType("int")
                        .HasColumnName("ServiciosID");

                    b.HasKey("SolicitudesId")
                        .HasName("PK__Solicitu__75DF73DD07EC6F2C");

                    b.HasIndex("ServiciosId");

                    b.ToTable("Solicitudes");
                });

            modelBuilder.Entity("Practicaprogramada005.Models.Solicitude", b =>
                {
                    b.HasOne("Practicaprogramada005.Models.Servicio", "Servicios")
                        .WithMany("Solicitudes")
                        .HasForeignKey("ServiciosId")
                        .IsRequired()
                        .HasConstraintName("FK__Solicitud__Servi__4BAC3F29");

                    b.Navigation("Servicios");
                });

            modelBuilder.Entity("Practicaprogramada005.Models.Servicio", b =>
                {
                    b.Navigation("Solicitudes");
                });
#pragma warning restore 612, 618
        }
    }
}
