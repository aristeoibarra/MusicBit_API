using Microsoft.EntityFrameworkCore;
using MusicBit.Core.Entities;
using MusicBit.Core.Interfaces;
using MusicBit.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBit.Infrastructure.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly MusicBitContext _context;
        public ArtistRepository(MusicBitContext context)
        {
            _context = context;
        }
       
        public async Task<IEnumerable<Artist>> GetArtists()
        {
            var artists = await  _context.Artists.ToListAsync();
            return artists;
        }

        public async Task<Artist> GetArtist(int id)
        {
            var artist = await _context.Artists.FirstOrDefaultAsync(x => x.ArtistId == id);
            return artist;
        }

        public async Task InsertArtist(Artist artist)
        {
            _context.Artists.Add(artist);
            await _context.SaveChangesAsync();
        }
    }
}
