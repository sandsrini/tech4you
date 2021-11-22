using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tech4you.Models;

namespace tech4you.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaptoplistmastersController : ControllerBase
    {
        private readonly laptopContext _context;

        public LaptoplistmastersController(laptopContext context)
        {
            _context = context;
        }

        // GET: api/Laptoplistmasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Laptoplistmaster>>> GetLaptoplistmasters()
        {
            return await _context.Laptoplistmasters.ToListAsync();
        }

        // GET: api/Laptoplistmasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Laptoplistmaster>> GetLaptoplistmaster(int id)
        {
            var laptoplistmaster = await _context.Laptoplistmasters.FindAsync(id);

            if (laptoplistmaster == null)
            {
                return NotFound();
            }

            return laptoplistmaster;
        }

        // PUT: api/Laptoplistmasters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLaptoplistmaster(int id, Laptoplistmaster laptoplistmaster)
        {
            if (id != laptoplistmaster.Laptopid)
            {
                return BadRequest();
            }

            _context.Entry(laptoplistmaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LaptoplistmasterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Laptoplistmasters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Laptoplistmaster>> PostLaptoplistmaster(Laptoplistmaster laptoplistmaster)
        {
            _context.Laptoplistmasters.Add(laptoplistmaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLaptoplistmaster", new { id = laptoplistmaster.Laptopid }, laptoplistmaster);
        }

        // DELETE: api/Laptoplistmasters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLaptoplistmaster(int id)
        {
            var laptoplistmaster = await _context.Laptoplistmasters.FindAsync(id);
            if (laptoplistmaster == null)
            {
                return NotFound();
            }

            _context.Laptoplistmasters.Remove(laptoplistmaster);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LaptoplistmasterExists(int id)
        {
            return _context.Laptoplistmasters.Any(e => e.Laptopid == id);
        }
    }
}
