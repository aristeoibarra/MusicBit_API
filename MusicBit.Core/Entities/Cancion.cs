#nullable disable

namespace MusicBit.Core.Entities
{
    public partial class Cancion
    {
        public int IdCancion { get; set; }
        public string Titulo { get; set; }
        public string Letra { get; set; }
        public int IdArtista { get; set; }
        public int IdGenero { get; set; }

        public virtual Artistum IdArtistaNavigation { get; set; }
        public virtual Genero IdGeneroNavigation { get; set; }
    }
}
