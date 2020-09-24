using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCTuinCentrumCore.Filters;
using MVCTuinCentrumCore.Models;

namespace MVCTuinCentrumCore.Controllers
{
    [TypeFilter(typeof(CustomExceptionFilter))]
    public class SoortController : Controller
    {
        //private readonly MVCTuinCentrumCoreContext _context;

        //public SoortController(MVCTuinCentrumCoreContext context)
        //{
        //    _context = context;
        //}
        private readonly ISoortenRepository soortenRepository;
        public SoortController(ISoortenRepository soortenRepository)
        {
            this.soortenRepository = soortenRepository;
        }
        // GET: Soort
        public async Task<IActionResult> Index()
        {
            //throw new Exception();
            //int deler = 0;
            //int resultaat = 5 / deler;
            return View(await soortenRepository.GetSoorten());
        }

        // GET: Soort/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var soort = await soortenRepository.GetSoort(id);
            if (soort == null)
            {
                return NotFound();
            }

            return View(soort);
        }

        // GET: Soort/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Soort/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SoortNr,Naam,MagazijnNr")] Soort soort)
        {
            if (ModelState.IsValid)
            {
                await soortenRepository.Add(soort);
                return RedirectToAction(nameof(Index));
            }
            return View(soort);
        }

        // GET: Soort/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var soort = await soortenRepository.GetSoort(id);
            if (soort == null)
            {
                return NotFound();
            }
            return View(soort);
        }

        // POST: Soort/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SoortNr,Naam,MagazijnNr")] Soort soort)
        {
            if (id != soort.SoortNr)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await soortenRepository.Update(soort);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await soortenRepository.GetSoort(soort.SoortNr) == null)
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
            return View(soort);
        }

        // GET: Soort/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var soort = await soortenRepository.GetSoort(id);
            if (soort == null)
            {
                return NotFound();
            }

            return View(soort);
        }

        // POST: Soort/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await soortenRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        //private bool SoortExists(int id)
        //{
        //    return _context.Soorten.Any(e => e.SoortNr == id);
        //}

        // GET: /Soort/Zoekform
        public IActionResult ZoekForm()
        {
            return View(new ZoekSoortViewModel());
        }

        //public async Task<IActionResult> BeginNaam(ZoekSoortViewModel form)
        //{
        //    if (this.ModelState.IsValid)
        //    {
        //        var soorten = await _context.Soorten
        //            .OrderBy(s => s.Naam)
        //            .Where(s => s.Naam.StartsWith(form.BeginNaam))
        //            .ToListAsync();
        //        form.Soorten = soorten;
        //    }
        //    return View("ZoekForm", form);
        //}
        // GET: /Soort/Zoekform
        public async Task<IActionResult> BeginNaam(ZoekSoortViewModel form)
        {
            if (this.ModelState.IsValid)
            {
                form.Soorten = await soortenRepository.FingByBeginNaam(form.BeginNaam);
            }
            return View("ZoekForm", form);
        }
    }
}
