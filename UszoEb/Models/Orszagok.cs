using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace UszoEb.Models
{
    public partial class Orszagok
    {
        public Orszagok()
        {
            Versenyzoks = new HashSet<Versenyzok>();
        }

        public int Id { get; set; }
        public string Nev { get; set; } = null!;
        public string Nobid { get; set; } = null!;
        [JsonIgnore]
        public virtual ICollection<Versenyzok>? Versenyzoks { get; set; }
    }
}
