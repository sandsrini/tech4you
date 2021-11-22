using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tech4you.Models;
using laptopcusmvc.Models;

namespace webapp2mvc.Controllers
{
    public class LaptoplistmastersController : Controller
    {
        private readonly laptopContext _context;

        public LaptoplistmastersController(laptopContext context)
        {
            _context = context;
        }

        // GET: Laptoplistmasters
        public async Task<IActionResult> Laptoplistsmaster()
        {
            return View(await _context.Laptoplistmasters.ToListAsync());
        }

        // GET: Laptoplistmasters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laptoplistmaster = await _context.Laptoplistmasters
                .FirstOrDefaultAsync(m => m.Laptopid == id);
            if (laptoplistmaster == null)
            {
                return NotFound();
            }

            return View(laptoplistmaster);
        }

        // GET: Laptoplistmasters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Laptoplistmasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Laptopid,Laptopname,Brandname,Price,Processor,Display,Os,Storagetype,Productcolor,Antivirus,Warranty,Laptopimage,Memory")] Laptoplistmaster laptoplistmaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(laptoplistmaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(laptoplistmaster);
        }

        // GET: Laptoplistmasters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laptoplistmaster = await _context.Laptoplistmasters.FindAsync(id);
            if (laptoplistmaster == null)
            {
                return NotFound();
            }
            return View(laptoplistmaster);
        }

        // POST: Laptoplistmasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Laptopid,Laptopname,Brandname,Price,Processor,Display,Os,Storagetype,Productcolor,Antivirus,Warranty,Laptopimage,Memory")] Laptoplistmaster laptoplistmaster)
        {
            if (id != laptoplistmaster.Laptopid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(laptoplistmaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaptoplistmasterExists(laptoplistmaster.Laptopid))
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
            return View(laptoplistmaster);
        }

        // GET: Laptoplistmasters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laptoplistmaster = await _context.Laptoplistmasters
                .FirstOrDefaultAsync(m => m.Laptopid == id);
            if (laptoplistmaster == null)
            {
                return NotFound();
            }

            return View(laptoplistmaster);
        }

        // POST: Laptoplistmasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var laptoplistmaster = await _context.Laptoplistmasters.FindAsync(id);
            _context.Laptoplistmasters.Remove(laptoplistmaster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaptoplistmasterExists(int id)
        {
            return _context.Laptoplistmasters.Any(e => e.Laptopid == id);
        }
    }
}
