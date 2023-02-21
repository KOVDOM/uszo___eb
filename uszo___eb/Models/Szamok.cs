using System;
using System.Collections.Generic;

namespace uszo___eb.Models
{
    public partial class Szamok
    {
        public int Id { get; set; }
        public string Nev { get; set; } = null!;
        public int VersenyzoId { get; set; }

        public virtual Versenyzok Versenyzo { get; set; } = null!;
    }
}
