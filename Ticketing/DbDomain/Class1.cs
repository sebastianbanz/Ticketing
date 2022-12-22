using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Models;

namespace DbDomain
{
    internal class IndContext:DbContext
    {
        public DbSet<Individual> Individuals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "data Source = (localdb)\\MSSQLocalDB; Initial Catalog = PutDatabase"
                );
        }
    }

    
}
