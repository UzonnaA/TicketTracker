using Microsoft.EntityFrameworkCore;
using TicketTracker.Models;

namespace TicketTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Ticket> Tickets => Set<Ticket>();
    }
}