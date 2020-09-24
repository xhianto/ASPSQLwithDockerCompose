using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCTuinCentrumCore.Controllers
{
    public class StatistiekController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
