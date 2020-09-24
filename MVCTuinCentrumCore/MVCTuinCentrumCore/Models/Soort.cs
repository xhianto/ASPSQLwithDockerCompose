using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCTuinCentrumCore.Models
{
    public partial class Soort
    {
        public Soort()
        {
            Planten = new HashSet<Plant>();
        }
        [Display(Name = "Soort")]
        public int SoortNr { get; set; }
        [StringLength(30)]
        public string Naam { get; set; }
        [Display(Name = "Magazijnnummer")]
        public byte MagazijnNr { get; set; }
        [Display(Name = "Planten")]
        public virtual ICollection<Plant> Planten { get; set; }
    }
}
