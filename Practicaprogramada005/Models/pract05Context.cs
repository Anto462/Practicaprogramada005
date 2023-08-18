using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Practicaprogramada005.Models
{
    public partial class pract05Context : DbContext
    {
        public pract05Context()
        {
        }

        public pract05Context(DbContextOptions<pract05Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Servicio> Servicios { get; set; } = null!;
        public virtual DbSet<Solicitude> Solicitudes { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source= DESKTOP-ITEJBTN\\SQLEXPRESS; Initial Catalog=pract05; Persist Security Info=False; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.ServiciosId)
                    .HasName("PK__Servicio__ED7749BA09E86233");

                entity.Property(e => e.ServiciosId).HasColumnName("ServiciosID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.Property(e => e.Nombre);
                entity.Property(e => e.Apellidos);
                entity.Property(e => e.Edad);
                entity.Property(e => e.Cedula);
                entity.Property(e => e.Resindencia);
                entity.Property(e => e.Usuario);
            });

            modelBuilder.Entity<Solicitude>(entity =>
            {
                entity.HasKey(e => e.SolicitudesId)
                    .HasName("PK__Solicitu__75DF73DD07EC6F2C");

                entity.Property(e => e.SolicitudesId).HasColumnName("SolicitudesID");

                entity.Property(e => e.Datsauto1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datsauto2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datsauto3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datsauto4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estadode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("estadode");

                entity.Property(e => e.Idusuario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IDUSUARIO");

                entity.Property(e => e.ServiciosId).HasColumnName("ServiciosID");

                entity.HasOne(d => d.Servicios)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.ServiciosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Solicitud__Servi__4BAC3F29");

                entity.Property(e => e.Mecanico);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
