using System.Collections.Generic;

namespace MusicBit.Core.Entities
{
    public partial class Artist
    {
        public Artist()
        {
            Songs = new HashSet<Song>();
        }

        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
