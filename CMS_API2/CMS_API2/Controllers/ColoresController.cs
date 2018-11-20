using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMS_API2.Models;

namespace CMS_API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoresController : ControllerBase
    {
        private readonly PRUEBASContext _context;

        public ColoresController(PRUEBASContext context)
        {
            _context = context;
        }

        // GET: api/Colores
        [HttpGet]
        public IEnumerable<Color> GetColor()
        {
            return _context.Color;
        }

        // GET: api/Colores/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var color = await _context.Color.FindAsync(id);

            if (color == null)
            {
                return NotFound();
            }

            return Ok(color);
        }

        // PUT: api/Colores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColor([FromRoute] int id, [FromBody] Color color)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != color.IdColor)
            {
                return BadRequest();
            }

            _context.Entry(color).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ColorExists(id))
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

        // POST: api/Colores
        [HttpPost]
        public async Task<IActionResult> PostColor([FromBody] Color color)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Color.Add(color);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetColor", new { id = color.IdColor }, color);
        }

        // DELETE: api/Colores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var color = await _context.Color.FindAsync(id);
            if (color == null)
            {
                return NotFound();
            }

            _context.Color.Remove(color);
            await _context.SaveChangesAsync();

            return Ok(color);
        }

        private bool ColorExists(int id)
        {
            return _context.Color.Any(e => e.IdColor == id);
        }
    }
}