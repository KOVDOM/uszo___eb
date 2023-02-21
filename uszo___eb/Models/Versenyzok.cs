using System;
using System.Collections.Generic;

namespace uszo___eb.Models
{
    public partial class Versenyzok
    {
        public Versenyzok()
        {
            Szamoks = new HashSet<Szamok>();
        }

        public int Id { get; set; }
        public string Nev { get; set; } = null!;
        public int OrszagId { get; set; }
        public string Nem { get; set; } = null!;

        public virtual ICollection<Szamok> Szamoks { get; set; }
    }
}
