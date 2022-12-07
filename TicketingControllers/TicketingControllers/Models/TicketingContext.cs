using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TicketingBunch.Models
{
    public class TicketingContext : DbContext
    {
        public TicketingContext(DbContextOptions<TicketingContext> options)
            : base(options)
        {
        }

        public DbSet<Individual> Individuals { get; set; } = null!;
    }
}
