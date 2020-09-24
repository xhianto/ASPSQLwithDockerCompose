using System;
using System.Collections.Generic;

namespace MVCTuinCentrumCore.Models
{
    public partial class Leverancier
    {
        public Leverancier()
        {
            Planten = new HashSet<Plant>();
        }

        public int LevNr { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }
        public string PostNr { get; set; }
        public string Woonplaats { get; set; }

        public virtual ICollection<Plant> Planten { get; set; }
    }
}
