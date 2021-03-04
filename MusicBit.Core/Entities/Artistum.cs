using System;
using System.Collections.Generic;

#nullable disable

namespace MusicBit.Core.Entities
{
    public partial class Artistum
    {
        public Artistum()
        {
            Cancions = new HashSet<Cancion>();
        }

        public int IdArtista { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public virtual ICollection<Cancion> Cancions { get; set; }
    }
}
