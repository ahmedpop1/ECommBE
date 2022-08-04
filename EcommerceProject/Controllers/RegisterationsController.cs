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
    public class RegisterationsController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public RegisterationsController(EcommerceContext context)
        {
            _context = context;

        }

        // GET: api/Registerations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Registeration>>> GetRegisterations()
        {
            return await _context.Registerations.ToListAsync();
        }

        // GET: api/Registerations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Registeration>> GetRegisteration(string id)
        {
            var registeration = await _context.Registerations.FindAsync(id);

            if (registeration == null)
            {
                return NotFound();
            }

            return registeration;
        }

        // PUT: api/Registerations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegisteration(string id, Registeration registeration)
        {
            if (id != registeration.username)
            {
                return BadRequest();
            }

            _context.Entry(registeration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegisterationExists(id))
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

        // POST: api/Registerations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Registeration>> PostRegisteration(Registeration registeration)
        {
            _context.Registerations.Add(registeration);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RegisterationExists(registeration.username))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRegisteration", new { id = registeration.username }, registeration);
        }

        // DELETE: api/Registerations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegisteration(string id)
        {
            var registeration = await _context.Registerations.FindAsync(id);
            if (registeration == null)
            {
                return NotFound();
            }

            _context.Registerations.Remove(registeration);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RegisterationExists(string id)
        {
            return _context.Registerations.Any(e => e.username == id);
        }
    }
}
