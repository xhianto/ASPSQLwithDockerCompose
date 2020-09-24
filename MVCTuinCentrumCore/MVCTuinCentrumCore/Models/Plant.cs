using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MVCTuinCentrumCore.Models
{
    public partial class Plant
    {

        public int PlantNr { get; set; }
        [StringLength(30)]
        public string Naam { get; set; }
        [Display(Name = "Soort")]
        public int SoortNr { get; set; }
        [Display(Name = "Leverancier")]
        public int Levnr { get; set; }
        [StringLength(10)]
        public string Kleur { get; set; }
        [Display(Name = "LabelPrijs")]
        [DisplayFormat(DataFormatString = "{0:€ #,##0.00}")]
        [Range(0,1000, ErrorMessage = "RangePrijs")]
        public decimal VerkoopPrijs { get; set; }
        [Display(Name = "Leverancier")]
        public virtual Leverancier LevnrNavigation { get; set; }
        [Display(Name = "Soort")]
        public virtual Soort SoortNrNavigation { get; set; }
    }
}
