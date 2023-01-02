using DbDomain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Ticketing.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Ticketing.Controllers;

[Route("[controller]")]
[ApiController]
public class IndividualController : ControllerBase, IIndividual
{
    [HttpPost("{Fname}")]
    public void AddIndividual(string Fname)
    {

        var individual = new Individual { Fname = Fname };
        using var context = new Context();
        context.Individuals.Add(individual);
        context.SaveChanges();
    }

    [HttpGet("{id}")]
    public IEnumerable<Individual> GetIndividual(int id)
    {
        using var context = new Context();

        var individuals = context.Individuals.ToList();

        var individual = individuals.Where(c => c.Id.Equals(id));

        return individual; 

       
    }
}