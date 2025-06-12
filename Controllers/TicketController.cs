using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketTracker.Data;
using TicketTracker.Models;

namespace TicketTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TicketsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tickets = await _context.Tickets.ToListAsync();
            return Ok(tickets);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAll), new { ticket.Id }, ticket);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Resolve(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
                return NotFound();

            ticket.Status = "Resolved";
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
