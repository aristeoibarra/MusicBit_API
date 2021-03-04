using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicBit.Core.Entities;

namespace MusicBit.Infrastructure.Data.Configurations
{
    class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(e => e.GenreId);

            builder.ToTable("Genero");

            builder.Property(e => e.GenreId).HasColumnName("IdGenero");

            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasColumnName("Nombre")
                   .HasMaxLength(50)
                   .IsUnicode(false);
        }
    }
}
