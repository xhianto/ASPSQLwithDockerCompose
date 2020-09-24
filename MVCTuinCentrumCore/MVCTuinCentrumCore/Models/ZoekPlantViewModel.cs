using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTuinCentrumCore.Models
{
    public class ZoekPlantViewModel
    {
        [Display(Name = "Minimumbedrag:")]
        [Required(ErrorMessage = "Verplicht")]
        public decimal Vanaf { get; set; }
        public List<Plant> Planten { get; set; }
    }
}
