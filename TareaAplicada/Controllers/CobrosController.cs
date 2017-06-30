using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TareaAplicada.DAL;
using TareaAplicada.Models;

namespace TareaAplicada.Controllers
{
    [Produces("application/json")]
    [Route("api/Cobros")]
    public class CobrosController : Controller
    {
        private readonly Context _context;

        public CobrosController(Context context)
        {
            _context = context;
        }

        // GET: api/Cobros
        [HttpGet]
        public IEnumerable<Cobro> GetCobros()
        {
            return _context.Cobros;
        }

        // GET: api/Cobros/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCobro([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cobro = await _context.Cobros.SingleOrDefaultAsync(m => m.Id == id);

            if (cobro == null)
            {
                return NotFound();
            }

            return Ok(cobro);
        }

        // PUT: api/Cobros/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCobro([FromRoute] int id, [FromBody] Cobro cobro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cobro.Id)
            {
                return BadRequest();
            }

            _context.Entry(cobro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CobroExists(id))
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

        // POST: api/Cobros
        [HttpPost]
        public async Task<IActionResult> PostCobro([FromBody] Cobro cobro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Cobros.Add(cobro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCobro", new { id = cobro.Id }, cobro);
        }

        // DELETE: api/Cobros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCobro([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cobro = await _context.Cobros.SingleOrDefaultAsync(m => m.Id == id);
            if (cobro == null)
            {
                return NotFound();
            }

            _context.Cobros.Remove(cobro);
            await _context.SaveChangesAsync();

            return Ok(cobro);
        }

        private bool CobroExists(int id)
        {
            return _context.Cobros.Any(e => e.Id == id);
        }
    }
}