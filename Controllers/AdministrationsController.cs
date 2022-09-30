using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportClubApi.Data;
using SportClubApi.Models;

namespace SportClubApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministrationsController : ControllerBase
    {
        private readonly SportClubDbContext _context;

        public AdministrationsController(SportClubDbContext context)
        {
            _context = context;
        }

        // GET: api/Administrations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Administration>>> GetAdministrations()
        {
            return await _context.Administrations.ToListAsync();
        }

        // GET: api/Administrations/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Administration>> GetAdministration(int id)
        {
            var administration = await _context.Administrations.FindAsync(id);

            if (administration == null)
            {
                return NotFound();
            }

            return administration;
        }

        // PUT: api/Administrations/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdministration(int id, Administration administration)
        {
            if (id != administration.Id)
            {
                return BadRequest();
            }

            _context.Entry(administration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdministrationExists(id))
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

        // POST: api/Administrations
        [HttpPost]
        public async Task<ActionResult<Administration>> PostAdministration(Administration administration)
        {
            _context.Administrations.Add(administration);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdministration", new { id = administration.Id }, administration);
        }

        // DELETE: api/Administrations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdministration(int id)
        {
            var administration = await _context.Administrations.FindAsync(id);
            if (administration == null)
            {
                return NotFound();
            }

            _context.Administrations.Remove(administration);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdministrationExists(int id)
        {
            return _context.Administrations.Any(e => e.Id == id);
        }
    }
}
