using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MusicBit.Core.Entities;
using MusicBit.Infrastructure.Data.Configurations;

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

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());        
        }
    }
}
