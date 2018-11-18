using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CMS_API.Models
{
    public partial class PRUEBASContext : DbContext
    {
        //public PRUEBASContext()
        //{
        //}

        //public PRUEBASContext(DbContextOptions<PRUEBASContext> options)
        //    : base(options)
        //{
        //}

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Idioma> Idioma { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoColor> ProductoColor { get; set; }
        public virtual DbSet<ProductoIdioma> ProductoIdioma { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\LOCALFRANSERVER;Database=PRUEBAS;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.Property(e => e.IdCategoria).HasColumnName("ID_Categoria");

                entity.Property(e => e.NombreCategoria)
                    .HasColumnName("Nombre_Categoria")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasKey(e => e.IdColor);

                entity.Property(e => e.IdColor).HasColumnName("ID_Color");

                entity.Property(e => e.NombreColor)
                    .HasColumnName("Nombre_Color")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Idioma>(entity =>
            {
                entity.HasKey(e => e.IdIdioma);

                entity.Property(e => e.IdIdioma).HasColumnName("ID_Idioma");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.Property(e => e.IdProducto).HasColumnName("ID_Producto");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.CategoriaNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.Categoria)
                    .HasConstraintName("FK_Producto_Categoria");
            });

            modelBuilder.Entity<ProductoColor>(entity =>
            {
                entity.HasKey(e => new { e.IdProducto, e.IdColor });

                entity.Property(e => e.IdProducto).HasColumnName("ID_Producto");

                entity.Property(e => e.IdColor).HasColumnName("ID_Color");

                entity.HasOne(d => d.IdColorNavigation)
                    .WithMany(p => p.ProductoColor)
                    .HasForeignKey(d => d.IdColor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductoColor_Color");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.ProductoColor)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductoColor_Producto");
            });

            modelBuilder.Entity<ProductoIdioma>(entity =>
            {
                entity.HasKey(e => new { e.IdProducto, e.IdIdioma });

                entity.Property(e => e.IdProducto).HasColumnName("ID_Producto");

                entity.Property(e => e.IdIdioma).HasColumnName("ID_Idioma");

                entity.HasOne(d => d.IdIdiomaNavigation)
                    .WithMany(p => p.ProductoIdioma)
                    .HasForeignKey(d => d.IdIdioma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductoIdioma_Idioma");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.ProductoIdioma)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductoIdioma_Producto");
            });
        }
    }
}
