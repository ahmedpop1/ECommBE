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
    public class OrderDetialsController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public OrderDetialsController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: api/OrderDetials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDetials>>> GetDetials()
        {
            return await _context.Detials.ToListAsync();
        }

        // GET: api/OrderDetials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetials>> GetOrderDetials(int id)
        {
            var orderDetials = await _context.Detials.FindAsync(id);

            if (orderDetials == null)
            {
                return NotFound();
            }

            return orderDetials;
        }

        // PUT: api/OrderDetials/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderDetials(int id, OrderDetials orderDetials)
        {
            if (id != orderDetials.OrderId)
            {
                return BadRequest();
            }

            _context.Entry(orderDetials).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderDetialsExists(id))
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

        // POST: api/OrderDetials
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderDetials>> PostOrderDetials(OrderDetials orderDetials)
        {
            _context.Detials.Add(orderDetials);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OrderDetialsExists(orderDetials.OrderId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOrderDetials", new { id = orderDetials.OrderId }, orderDetials);
        }

        // DELETE: api/OrderDetials/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderDetials(int id)
        {
            var orderDetials = await _context.Detials.FindAsync(id);
            if (orderDetials == null)
            {
                return NotFound();
            }

            _context.Detials.Remove(orderDetials);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderDetialsExists(int id)
        {
            return _context.Detials.Any(e => e.OrderId == id);
        }
    }
}
