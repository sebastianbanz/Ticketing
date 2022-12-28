using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Models;
using static System.Net.Mime.MediaTypeNames;

namespace DbDomain
{
    internal class IndContext:DbContext
    {
        public DbSet<Individual> Individuals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = MET5CD1298Q5W; Initial Catalog = Test; Integrated Security = True; TrustServerCertificate=True");
        }

    }

    
}
