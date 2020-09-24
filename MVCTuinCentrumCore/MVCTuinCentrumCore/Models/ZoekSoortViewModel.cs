using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTuinCentrumCore.Models
{
    public class ZoekSoortViewModel
    {
        [Display(Name = "Begin soortnaam:")]
        [Required(ErrorMessage = "Verplicht")]
        [StringLength(8, ErrorMessage = "{0} moet minstens {2} tekens lang zijn", MinimumLength = 2)]
        public string BeginNaam { get; set; }
        public List<Soort> Soorten { get; set; }
    }
}
