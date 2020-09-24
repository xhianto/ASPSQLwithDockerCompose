using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTuinCentrumCore.Models
{
    public class FotoUploadViewModel
    {
        public int PlantNr { get; set; }
        public IFormFile Foto { get; set; }
    }
}
