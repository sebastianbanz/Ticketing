
using DbDomain;
using Microsoft.IdentityModel.Tokens;
using Ticketing.Models;

//using (IndContext context = new IndContext())
//{
//    context.Database.EnsureCreated();
//}
namespace DbDomain
{

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("press enter for list of individuals");
            Console.WriteLine("type a first name to insert it");
            var input = Console.ReadLine();
            if (input == "") 
            {
                Console.Clear();
                Console.WriteLine("loading...");
                GetIndividual();

                
            
            }else 
            {
                Console.Clear();
                Console.WriteLine("adding...");
                AddIndividual(input);
            
            }

        }

        public static void AddIndividual(string Fname)
        {

            var individual = new Individual { Fname = Fname};
            using var context = new IndContext();
            context.Individuals.Add(individual);
            context.SaveChanges();
            Main();
        }
        public static void GetIndividual()
        {

            using var context = new IndContext();
            var individuals = context.Individuals.ToList();
            foreach (var individual in individuals)
            { Console.WriteLine(individual.Fname + " " + individual.Lname); }
            Main();
        }
    }
}
