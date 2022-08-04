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
    public class CartItemsController : ControllerBase
    {
        private readonly EcommerceContext _context;


        public CartItemsController(EcommerceContext context)
        {
            _context = context;

        }

        // GET: api/CartItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CartItems>>> GetItems()
        {
            return await _context.Items.ToListAsync();
        }

        // GET: api/CartItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CartItems>> GetCartItems(int id)
        {
            var cartItems = await _context.Items.FindAsync(id);

            if (cartItems == null)
            {
                return NotFound();
            }

            return cartItems;
        }

        // PUT: api/CartItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCartItems(int id, CartItems cartItems)
        {
            if (id != cartItems.CartId)
            {
                return BadRequest();
            }

            _context.Entry(cartItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartItemsExists(id))
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

        // POST: api/CartItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CartItems>> PostCartItems(CartItems cartItems)
        {
            _context.Items.Add(cartItems);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CartItemsExists(cartItems.CartId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCartItems", new { id = cartItems.CartId }, cartItems);
        }

        // DELETE: api/CartItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartItems(int id)
        {
            var cartItems = await _context.Items.FindAsync(id);
            if (cartItems == null)
            {
                return NotFound();
            }

            _context.Items.Remove(cartItems);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CartItemsExists(int id)
        {
            return _context.Items.Any(e => e.CartId == id);
        }
    }
}
