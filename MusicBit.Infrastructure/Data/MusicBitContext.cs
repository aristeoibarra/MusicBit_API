using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MusicBit.Core.Entities;

#nullable disable

namespace MusicBit.Infrastructure.Data
{
    public partial class MusicBitContext : DbContext
    {
        public MusicBitContext()
        {
        }

        public MusicBitContext(DbContextOptions<MusicBitContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artistum> Artista { get; set; }
        public virtual DbSet<Cancion> Cancions { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Artistum>(entity =>
            {
                entity.HasKey(e => e.IdArtista);

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cancion>(entity =>
            {
                entity.HasKey(e => e.IdCancion);

                entity.ToTable("Cancion");

                entity.Property(e => e.Letra)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdArtistaNavigation)
                    .WithMany(p => p.Cancions)
                    .HasForeignKey(d => d.IdArtista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Artista");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Cancions)
                    .HasForeignKey(d => d.IdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Genero");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero);

                entity.ToTable("Genero");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
