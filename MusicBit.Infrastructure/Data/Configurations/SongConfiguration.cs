using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicBit.Core.Entities;

namespace MusicBit.Infrastructure.Data.Configurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Cancion");

            builder.HasKey(e => e.SongId);

            builder.Property(e => e.SongId).HasColumnName("IdCancion");

            builder.Property(e => e.Lyrics)
                   .IsRequired()
                   .HasColumnName("Letra")
                   .HasMaxLength(2000)
                   .IsUnicode(false);

            builder.Property(e => e.Title)
                   .IsRequired()
                   .HasColumnName("Titulo")
                   .HasMaxLength(50)
                   .IsUnicode(false);

            builder.HasOne(d => d.Artist)
                   .WithMany(p => p.Songs)
                   .HasForeignKey(d => d.ArtistId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Artista");

            builder.HasOne(d => d.Genres)
                   .WithMany(p => p.Cancions)
                   .HasForeignKey(d => d.GenreId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Genero");
        }
    }
}
