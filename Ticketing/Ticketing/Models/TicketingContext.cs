using Microsoft.EntityFrameworkCore;
using Ticketing.Models;


namespace Ticketing.Models
{

    internal class Context : DbContext
    {

        public DbSet<Individual> Individuals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer("Data Source = MET5CD1298Q5W; Initial Catalog = Test; Integrated Security = True; TrustServerCertificate=True");

  

            //list of test computers
            // metro   "Data Source = MET5CD1298Q5W; Initial Catalog = Test; Integrated Security = True; TrustServerCertificate=True"  
            // home desktop  "Data Source = DESKTOP-NN0DHGU\\SQLEXPRESS; Initial Catalog = Ticketing; Integrated Security = True; TrustServerCertificate=True"
        }

    }

}
