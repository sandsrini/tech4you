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
    public class CustomizedlaptopsController : ControllerBase
    {
        private readonly laptopContext _context;

        public CustomizedlaptopsController(laptopContext context)
        {
            _context = context;
        }

        // GET: api/Customizedlaptops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customizedlaptop>>> GetCustomizedlaptops()
        {
            return await _context.Customizedlaptops.ToListAsync();
        }

        // GET: api/Customizedlaptops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customizedlaptop>> GetCustomizedlaptop(int id)
        {
            var customizedlaptop = await _context.Customizedlaptops.FindAsync(id);

            if (customizedlaptop == null)
            {
                return NotFound();
            }

            return customizedlaptop;
        }

        // PUT: api/Customizedlaptops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomizedlaptop(int id, Customizedlaptop customizedlaptop)
        {
            if (id != customizedlaptop.Cuslaptopid)
            {
                return BadRequest();
            }

            _context.Entry(customizedlaptop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomizedlaptopExists(id))
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

        // POST: api/Customizedlaptops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customizedlaptop>> PostCustomizedlaptop(Customizedlaptop customizedlaptop)
        {
            _context.Customizedlaptops.Add(customizedlaptop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomizedlaptop", new { id = customizedlaptop.Cuslaptopid }, customizedlaptop);
        }

        // DELETE: api/Customizedlaptops/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomizedlaptop(int id)
        {
            var customizedlaptop = await _context.Customizedlaptops.FindAsync(id);
            if (customizedlaptop == null)
            {
                return NotFound();
            }

            _context.Customizedlaptops.Remove(customizedlaptop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomizedlaptopExists(int id)
        {
            return _context.Customizedlaptops.Any(e => e.Cuslaptopid == id);
        }
    }
}
