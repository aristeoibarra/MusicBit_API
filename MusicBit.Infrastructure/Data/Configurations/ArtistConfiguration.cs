using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicBit.Core.Entities;

namespace MusicBit.Infrastructure.Data.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artista");

            builder.HasKey(e => e.ArtistId);

            builder.Property(e => e.ArtistId)
                .HasColumnName("IdArtista");

            builder.Property(e => e.LastName)
                   .IsRequired()
                   .HasColumnName("Apellido")
                   .HasMaxLength(50)
                   .IsUnicode(false);

            builder.Property(e => e.FirstName)
                   .IsRequired()
                   .HasColumnName("Nombre")
                   .HasMaxLength(50)
                   .IsUnicode(false);
        }
    }
}
