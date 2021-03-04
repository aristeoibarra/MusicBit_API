using System.Collections.Generic;

namespace MusicBit.Core.Entities
{
    public partial class Genre
    {
        public Genre()
        {
            Cancions = new HashSet<Song>();
        }

        public int GenreId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Song> Cancions { get; set; }
    }
}
