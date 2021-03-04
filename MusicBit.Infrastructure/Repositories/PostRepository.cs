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
    public class PostRepository : IPostRepository
    {
        private readonly MusicBitContext _context;
        public PostRepository(MusicBitContext context)
        {
            _context = context;
        }
       
        public async Task<IEnumerable<Artistum>> GetPosts()
        {
            var posts = await  _context.Artista.ToListAsync();
            return posts;
        }
    }
}
