using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using laptopcusmvc.Models;
using laptopcusmvc.Helpers;
using tech4you.Models;

namespace webapp2mvc.Controllers
{
    public class CustomizedlaptopsController : Controller
    {
        helperAPI _api = new helperAPI();
        private readonly laptopContext _context;

        public CustomizedlaptopsController(laptopContext context)
        {
            _context = context;
        }

        // GET: Customizedlaptops
        public async Task<IActionResult> Report()
        {
            var laptopContext = _context.Customizedlaptops.Include(c => c.Display).Include(c => c.Os).Include(c => c.Processor).Include(c => c.Storagetype).Include(c => c.Warranty);
            return View(await laptopContext.ToListAsync());
        }

        // GET: Customizedlaptops/Details/5
        public async Task<IActionResult> invoice(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customizedlaptop = await _context.Customizedlaptops
                .Include(c => c.Display)
                .Include(c => c.Os)
                .Include(c => c.Processor)
                .Include(c => c.Storagetype)
                .Include(c => c.Warranty)
                .FirstOrDefaultAsync(m => m.Cuslaptopid == id);
            if (customizedlaptop == null)
            {
                return NotFound();
            }

            return View(customizedlaptop);
        }

        // GET: Customizedlaptops/Create
        public async Task<IActionResult> Customize(int id)
        {
            
            //var laptoplist = await _context.laptoplistmasters.findasync(id);
            HttpClient cli = _api.Initial();
            var std1 = new Laptoplistmaster();
            //var display = new Displaytbl();
            Customizedlaptop stud = new Customizedlaptop();
            HttpResponseMessage result2 = await cli.GetAsync($"api/laptoplistmasters/{id}");
            HttpResponseMessage response = await cli.GetAsync($"api/Customizedlaptops/{id}");
            //HttpResponseMessage displayresponse = await cli.GetAsync($"api/Displaytbls/{id}");



            if (result2.IsSuccessStatusCode)
            {
                var res2 = result2.Content.ReadAsStringAsync().Result;
                //var res = displayresponse.Content.ReadAsStringAsync().Result;
                string data = response.Content.ReadAsStringAsync().Result;
                std1 = JsonConvert.DeserializeObject<Laptoplistmaster>(res2);
                //display = JsonConvert.DeserializeObject<Displaytbl>(res);
                //stud = JsonConvert.DeserializeObject<Customizedlaptop>(data);
            }
            //ViewData["price"] = display.Price;
            ViewData["Brandname"] = std1.Brandname;
            ViewData["Processor"] = std1.Processor;
            ViewData["Memory"] = std1.Memory;
            ViewData["Os"] = std1.Os;
            ViewData["Productcolor"] = std1.Productcolor;
            ViewData["Storagetype"] = std1.Storagetype;
            ViewData["Laptopname"] = std1.Laptopname;
            ViewData["Price"] = std1.Price;
            ViewData["Antivirus"] = std1.Antivirus;
            ViewData["Display"] = std1.Display;
            ViewData["laptopimage"] = std1.Laptopimage;

            //ViewBag.price = new SelectList(_context.Displaytbls, "price","Displaysize");

            var demo = new SelectList(_context.Displaytbls, "Price", "Displaysize");
            var demo1 = new SelectList(_context.Displaytbls, "Displaysize", "Displaysize");
            var demo2 = new SelectList(_context.Displaytbls, "Displayid", "Displaysize");
            ViewData["Displayid"] = new SelectList(_context.Displaytbls, "Displayid", "Displaysize");
            ViewData["Osid"] = new SelectList(_context.Ostbls, "Osid", "Osname");
            ViewData["Processorid"] = new SelectList(_context.Processortbls, "Processorid", "Processorname");
            ViewData["Storagetypeid"] = new SelectList(_context.Storagetypetbls, "Storagetypeid", "Storagetypename");
            ViewData["Warrantyid"] = new SelectList(_context.Warrantytbls, "Warrantyid", "Warrantyperiod");
            return View();
        }



        // POST: Customizedlaptops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CustomizeAsync([Bind("Cuslaptopid,Cuslaptopname,Cusbrandname,Cusprice,Cusantivirus,Username,Email,Processorid,Displayid,Osid,Storagetypeid,Warrantyid,Quantity,Grandtotal,Purchasedate,Invoiceid")] Customizedlaptop customizedlaptop)
        {

            if (ModelState.IsValid)
            {
                _context.Add(customizedlaptop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Report));
            }
            ViewData["Displayid"] = new SelectList(_context.Displaytbls, "Displayid", "Displaysize", customizedlaptop.Displayid);
            ViewData["Osid"] = new SelectList(_context.Ostbls, "Osid", "Osname", customizedlaptop.Osid);
            ViewData["Processorid"] = new SelectList(_context.Processortbls, "Processorid", "Processorname", customizedlaptop.Processorid);
            ViewData["Storagetypeid"] = new SelectList(_context.Storagetypetbls, "Storagetypeid", "Storagetypename", customizedlaptop.Storagetypeid);
            ViewData["Warrantyid"] = new SelectList(_context.Warrantytbls, "Warrantyid", "Warrantyperiod", customizedlaptop.Warrantyid);
            return View(customizedlaptop);
        }

        // GET: Customizedlaptops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customizedlaptop = await _context.Customizedlaptops.FindAsync(id);
            if (customizedlaptop == null)
            {
                return NotFound();
            }
            ViewData["Displayid"] = new SelectList(_context.Displaytbls, "Displayid", "Displaysize", customizedlaptop.Displayid);
            ViewData["Osid"] = new SelectList(_context.Ostbls, "Osid", "Osname", customizedlaptop.Osid);
            ViewData["Processorid"] = new SelectList(_context.Processortbls, "Processorid", "Processorname", customizedlaptop.Processorid);
            ViewData["Storagetypeid"] = new SelectList(_context.Storagetypetbls, "Storagetypeid", "Storagetypename", customizedlaptop.Storagetypeid);
            ViewData["Warrantyid"] = new SelectList(_context.Warrantytbls, "Warrantyid", "Warrantyperiod", customizedlaptop.Warrantyid);
            return View(customizedlaptop);
        }

        // POST: Customizedlaptops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Cuslaptopid,Cuslaptopname,Cusbrandname,Cusprice,Cusantivirus,Username,Email,Processorid,Displayid,Osid,Storagetypeid,Warrantyid,Quantity,Grandtotal,Purchasedate,Invoiceid")] Customizedlaptop customizedlaptop)
        {
            if (id != customizedlaptop.Cuslaptopid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customizedlaptop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomizedlaptopExists(customizedlaptop.Cuslaptopid))
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
            ViewData["Displayid"] = new SelectList(_context.Displaytbls, "Displayid", "Displaysize", customizedlaptop.Displayid);
            ViewData["Osid"] = new SelectList(_context.Ostbls, "Osid", "Osname", customizedlaptop.Osid);
            ViewData["Processorid"] = new SelectList(_context.Processortbls, "Processorid", "Processorname", customizedlaptop.Processorid);
            ViewData["Storagetypeid"] = new SelectList(_context.Storagetypetbls, "Storagetypeid", "Storagetypename", customizedlaptop.Storagetypeid);
            ViewData["Warrantyid"] = new SelectList(_context.Warrantytbls, "Warrantyid", "Warrantyperiod", customizedlaptop.Warrantyid);
            return View(customizedlaptop);
        }

        // GET: Customizedlaptops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customizedlaptop = await _context.Customizedlaptops
                .Include(c => c.Display)
                .Include(c => c.Os)
                .Include(c => c.Processor)
                .Include(c => c.Storagetype)
                .Include(c => c.Warranty)
                .FirstOrDefaultAsync(m => m.Cuslaptopid == id);
            if (customizedlaptop == null)
            {
                return NotFound();
            }

            return View(customizedlaptop);
        }

        // POST: Customizedlaptops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customizedlaptop = await _context.Customizedlaptops.FindAsync(id);
            _context.Customizedlaptops.Remove(customizedlaptop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomizedlaptopExists(int id)
        {
            return _context.Customizedlaptops.Any(e => e.Cuslaptopid == id);
        }

        //    public async Task<IActionResult> displayprice(int id)
        //{
        //    var quan = new Displaytbl();
        //        var displaytbl = await _context.Displaytbls
        //            .FirstOrDefaultAsync(m => m.Displayid == id);
        //        if (displaytbl == null)
        //        {
        //            return NotFound();
        //        }
        //        return View();
        //}
        public IActionResult Getprocessorprice()
        {

            List<Processortbl> price = _context.Processortbls.ToList<Processortbl>();
            return Json(new { data = price }, new Newtonsoft.Json.JsonSerializerSettings());
        }
        public IActionResult Getosprice()
        {

            List<Ostbl> price = _context.Ostbls.ToList<Ostbl>();
            return Json(new { data = price }, new Newtonsoft.Json.JsonSerializerSettings());
        }
        public IActionResult Getdisplayprice()
        {

            List<Displaytbl> price = _context.Displaytbls.ToList<Displaytbl>();
            return Json(new { data = price }, new Newtonsoft.Json.JsonSerializerSettings());
        }
        public IActionResult Getstorageprice()
        {

            List<Storagetypetbl> price = _context.Storagetypetbls.ToList<Storagetypetbl>();
            return Json(new { data = price }, new Newtonsoft.Json.JsonSerializerSettings());
        }
        public IActionResult Getwarrantyprice()
        {

            List<Warrantytbl> price = _context.Warrantytbls.ToList<Warrantytbl>();
            return Json(new { data = price }, new Newtonsoft.Json.JsonSerializerSettings());
        }

    }
}
