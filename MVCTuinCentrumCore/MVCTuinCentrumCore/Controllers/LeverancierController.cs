using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCTuinCentrumCore.Models;

namespace MVCTuinCentrumCore.Controllers
{
    public class LeverancierController : Controller
    {
        private readonly ILeveranciersRepository leveranciersRepository;
        public LeverancierController(ILeveranciersRepository leveranciersRepository)
        {
            this.leveranciersRepository = leveranciersRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View(await leveranciersRepository.GetLeveranciers());
        }
        [Route("Leveranciers/{postnr?}")]
        public async Task<IActionResult> FindLeveranciersMetPostNr(string postnr)
        {
            if (postnr == null)
                return View("Index", await leveranciersRepository.GetLeveranciers());
            else
            {
                List<Leverancier> leveranciersLijst = await leveranciersRepository.GetLeveranciersMetPostNr(postnr);
                ViewBag.postnr = postnr;
                return View(leveranciersLijst);
            }
        }
    }
}
