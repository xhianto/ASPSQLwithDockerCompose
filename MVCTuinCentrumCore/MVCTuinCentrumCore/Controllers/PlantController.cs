using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCTuinCentrumCore.Models;
using MVCTuinCentrumCore.Filters;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace MVCTuinCentrumCore.Controllers
{
    [StatistiekActionFilter]
    public class PlantController : Controller
    {
        private readonly MVCTuinCentrumCoreContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public PlantController(MVCTuinCentrumCoreContext context, IWebHostEnvironment environment)
        {
            _context = context;
            webHostEnvironment = environment;
        }

        //private readonly IPlantRepository plantenRepository;
        //public PlantController(IPlantRepository plantenRepository)
        //{
        //    this.plantenRepository = plantenRepository;
        //}

        // GET: Plant
        public async Task<IActionResult> Index()
        {
            var mVCTuinCentrumCoreContext = _context.Planten.Include(p => p.LevnrNavigation).Include(p => p.SoortNrNavigation);
            return View(await mVCTuinCentrumCoreContext.ToListAsync());
            //return View(await plantenRepository.GetPlanten());
        }

        // GET: Plant/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plant = await _context.Planten
                .Include(p => p.LevnrNavigation)
                .Include(p => p.SoortNrNavigation)
                .FirstOrDefaultAsync(m => m.PlantNr == id);
            //var plant = await plantenRepository.GetPlant(id);
            if (plant == null)
            {
                return NotFound();
            }

            return View(plant);
        }

        // GET: Plant/Create
        public IActionResult Create()
        {
            ViewData["Levnr"] = new SelectList(_context.Leveranciers, "LevNr", "Naam");
            ViewData["SoortNr"] = new SelectList(_context.Soorten, "SoortNr", "Naam");
            return View();
        }

        // POST: Plant/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlantNr,Naam,SoortNr,Levnr,Kleur,VerkoopPrijs")] Plant plant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plant);
                await _context.SaveChangesAsync();
                //await plantenRepository.Add(plant);
                return RedirectToAction(nameof(Index));
            }
            ViewData["Levnr"] = new SelectList(_context.Leveranciers, "LevNr", "Naam", plant.Levnr);
            ViewData["SoortNr"] = new SelectList(_context.Soorten, "SoortNr", "Naam", plant.SoortNr);
            return View(plant);
        }

        // GET: Plant/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plant = await _context.Planten.FindAsync(id);
            if (plant == null)
            {
                return NotFound();
            }
            ViewData["Levnr"] = new SelectList(_context.Leveranciers, "LevNr", "Naam", plant.Levnr);
            ViewData["SoortNr"] = new SelectList(_context.Soorten, "SoortNr", "Naam", plant.SoortNr);
            return View(plant);
        }

        // POST: Plant/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlantNr,Naam,SoortNr,Levnr,Kleur,VerkoopPrijs")] Plant plant)
        {
            if (id != plant.PlantNr)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlantExists(plant.PlantNr))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Levnr"] = new SelectList(_context.Leveranciers, "LevNr", "Naam", plant.Levnr);
            ViewData["SoortNr"] = new SelectList(_context.Soorten, "SoortNr", "Naam", plant.SoortNr);
            return View(plant);
        }

        // GET: Plant/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plant = await _context.Planten
                .Include(p => p.LevnrNavigation)
                .Include(p => p.SoortNrNavigation)
                .FirstOrDefaultAsync(m => m.PlantNr == id);
            if (plant == null)
            {
                return NotFound();
            }

            return View(plant);
        }

        // POST: Plant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plant = await _context.Planten.FindAsync(id);
            _context.Planten.Remove(plant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlantExists(int id)
        {
            return _context.Planten.Any(e => e.PlantNr == id);
        }
        [HttpGet]
        public IActionResult Uploaden(int id)
        {
            var fotoUploadViewModel = new FotoUploadViewModel();
            fotoUploadViewModel.PlantNr = id;
            return View(fotoUploadViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> FotoUpload(FotoUploadViewModel fotoUploadViewModel)
        {
            if (fotoUploadViewModel.Foto != null && Path.GetExtension(fotoUploadViewModel.Foto.FileName) == ".jpg")
            {
                var fileName = fotoUploadViewModel.PlantNr.ToString() + ".jpg";
                var uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                var filePath = Path.Combine(uploadFolder, fileName);
                await fotoUploadViewModel.Foto.CopyToAsync(new FileStream(filePath, FileMode.Create));
            }
            return RedirectToAction("Index");
        }
        public IActionResult ZoekForm()
        {
            return View(new ZoekPlantViewModel());
        }

        public async Task<IActionResult> VanafPrijs(ZoekPlantViewModel form)
        {
            if (this.ModelState.IsValid)
            {
                var planten = await _context.Planten
                    .OrderBy(s => s.Naam)
                    .Where(s => s.VerkoopPrijs >= form.Vanaf)
                    .ToListAsync();
                form.Planten = planten;
            }
            return View("ZoekForm", form);
        }
        public IActionResult FindPlantenBySoortNaam(string soortnaam)
        {
            List<Plant> plantenLijst = new List<Plant>();
            plantenLijst = (from plant in _context.Planten
                                .Include("SoortNrNavigation")
                                .Include("LevnrNavigation")
                            where plant.SoortNrNavigation.Naam.StartsWith(soortnaam)
                            select plant).ToList();
            ViewBag.Title = "Planten van de soort dat begint met '" + soortnaam + "'";
            return View("Plantenlijst", plantenLijst);
        }
        public IActionResult FindPlantenByLeverancier(int levnr)
        {
            List<Plant> plantenLijst = new List<Plant>();
            plantenLijst = (from plant in _context.Planten
                                .Include("LevnrNavigation")
                                .Include("SoortNrNavigation")
                            where plant.LevnrNavigation.LevNr == levnr
                            select plant).ToList();
            var leverancier = _context.Leveranciers.Find(levnr);
            ViewBag.Title = "Planten van leverancier '" + leverancier.Naam + "'";
            return View("Plantenlijst", plantenLijst);
        }
        public IActionResult FindPlantenByKleur(string kleur)
        {
            List<Plant> plantenLijst = new List<Plant>();
            plantenLijst = (from plant in _context.Planten
                                .Include("SoortNrNavigation")
                                .Include("LevnrNavigation")
                            where plant.Kleur == kleur
                            select plant).ToList();
            return View("Index", plantenLijst);
        }
        public IActionResult FindPlantenBetweenPrijzen(decimal minPrijs, decimal maxPrijs)
        {
            List<Plant> plantenLijst = new List<Plant>();
            plantenLijst = (from plant in _context.Planten
                                .Include("SoortNrNavigation")
                                .Include("LevnrNavigation")
                            where plant.VerkoopPrijs >= minPrijs && plant.VerkoopPrijs <= maxPrijs
                            select plant).ToList();
            //ViewBag.minprijs = minPrijs;
            //ViewBag.maxprijs = maxPrijs;
            ViewBag.Title = "Planten met prijs tussen € " + minPrijs + " en € " + maxPrijs;
            return View("PlantenLijst", plantenLijst);
        }
        [Route("plantinfo/{id:int}")]
        public ActionResult FindPlantById(int id)
        {
            var plant = _context.Planten.Find(id);
            if (plant != null)
                return View("Details", plant);
            else
            {
                var planten =
                    _context.Planten
                    .Include(p => p.LevnrNavigation)
                    .Include(p => p.SoortNrNavigation);
                return View("Index", planten.ToList());
            }
        }
        [Route("plantinfo/{naam}")]
        public ActionResult FindPlantByName(string naam)
        {
            var plant = (from p in _context.Planten
                         where p.Naam == naam
                         select p).FirstOrDefault();
            if (plant != null)
                return View("Details", plant);
            else
            {
                var planten =
                    _context.Planten
                    .Include(p => p.LevnrNavigation)
                    .Include(p => p.SoortNrNavigation);
                return View("Index", planten.ToList());
            }
        }
        [Route("plantenprijzen/{btw:values(inclusief|exclusief)}", Name="btwinex")]
        public IActionResult PrijsLijst(string btw)
        {
            ViewBag.btw = btw;
            return View(_context.Planten.ToList());
        }
    }
}
