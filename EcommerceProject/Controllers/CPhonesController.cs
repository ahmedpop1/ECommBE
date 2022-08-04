using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcommerceProject.models;

namespace EcommerceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CPhonesController : ControllerBase
    {

        private readonly EcommerceContext _context;

        public CPhonesController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: api/CPhones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CPhone>>> GetCPhone()
        {
            return await _context.CPhone.ToListAsync();
        }

        // GET: api/CPhones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CPhone>> GetCPhone(int id)
        {
            var cPhone = await _context.CPhone.FindAsync(id);

            if (cPhone == null)
            {
                return NotFound();
            }

            return cPhone;
        }

        // PUT: api/CPhones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCPhone(int id, CPhone cPhone)
        {
            if (id != cPhone.ID)
            {
                return BadRequest();
            }

            _context.Entry(cPhone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CPhoneExists(id))
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

        // POST: api/CPhones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CPhone>> PostCPhone(CPhone cPhone)
        {
            _context.CPhone.Add(cPhone);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCPhone", new { id = cPhone.ID }, cPhone);
        }

        // DELETE: api/CPhones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCPhone(int id)
        {
            var cPhone = await _context.CPhone.FindAsync(id);
            if (cPhone == null)
            {
                return NotFound();
            }

            _context.CPhone.Remove(cPhone);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CPhoneExists(int id)
        {
            return _context.CPhone.Any(e => e.ID == id);
        }
    }
}
