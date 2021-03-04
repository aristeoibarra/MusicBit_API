namespace MusicBit.Core.Entities
{
    public partial class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public string Lyrics { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Genre Genres { get; set; }
    }
}
