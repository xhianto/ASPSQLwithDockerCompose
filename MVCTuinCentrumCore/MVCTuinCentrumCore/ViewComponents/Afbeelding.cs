using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTuinCentrumCore.ViewComponents
{
    public class Afbeelding : ViewComponent
    {
        private readonly IWebHostEnvironment env;
        public Afbeelding(IWebHostEnvironment env)
        {
            this.env = env;
        }
        public IViewComponentResult Invoke(int plaatnummer)
        {
            var imageFilenaamMetPad = Path.Combine(env.WebRootPath, "images", plaatnummer + ".jpg");
            var imageSource = File.Exists(imageFilenaamMetPad) ? plaatnummer.ToString() : "default";
            return View((object)imageSource);
        }
    }
}
