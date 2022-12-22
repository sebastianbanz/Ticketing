
using DbDomain;

using (IndContext context = new IndContext())
{
    context.Database.EnsureCreated();
}

void GetIndividuals()
{
    using var context = new IndContext();
    var individual = context.Individuals.ToList();
    foreach(var ind in individual) 
    {Console.WriteLine("bingas " + individual.Fname ); }
}