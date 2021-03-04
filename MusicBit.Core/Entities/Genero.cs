using System.Collections.Generic;

#nullable disable

namespace MusicBit.Core.Entities
{
    public partial class Genero
    {
        public Genero()
        {
            Cancions = new HashSet<Cancion>();
        }

        public int IdGenero { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Cancion> Cancions { get; set; }
    }
}
