using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Models;


namespace Ticketing.Models
{
    internal class Context : DbContext
    {

        public DbSet<Individual> Individuals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-NN0DHGU\\SQLEXPRESS; Initial Catalog = Ticketing; Integrated Security = True; TrustServerCertificate=True");
        }

    }

}
