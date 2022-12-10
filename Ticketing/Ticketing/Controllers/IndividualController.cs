using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ticketing.Models;

namespace TicketingBunch.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IndividualController : ControllerBase
{
    private readonly TicketingContext _context;

    public IndividualController(TicketingContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<IndividualDTO>>> GetIndividuals()
    {
        return await _context.Individuals
            .Select(x => IndividualToDTO(x))
            .ToListAsync();
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<IndividualDTO>> GetIndividual(int id)
    {
        var individual = await _context.Individuals.FindAsync(id);

        if (individual == null)
        {
            return NotFound();
        }

        return IndividualToDTO(individual);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutIndividual(int id, IndividualDTO individualDTO)
    {
        if (id != individualDTO.Id)
        {
            return BadRequest();
        }

        var individual = await _context.Individuals.FindAsync(id);
        if (individual == null)
        {
            return NotFound();
        }

        individual.Fname = individualDTO.Fname;
       

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException) when (!IndividualExists(id))
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<IndividualDTO>> PostIndividual(IndividualDTO individualDTO)
    {
        var individual = new Individual
        {

            Fname = individualDTO.Fname
        };

        _context.Individuals.Add(individual);
        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetIndividual),
            new { id = individual.Id },
            IndividualToDTO(individual));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Deleteindividual(int id)
    {
        var individual = await _context.Individuals.FindAsync(id);
        if (individual == null)
        {
            return NotFound();
        }

        _context.Individuals.Remove(individual);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool IndividualExists(int id)
    {
        return _context.Individuals.Any(e => e.Id == id);
    }

    private static IndividualDTO IndividualToDTO(Individual individual) =>
       new IndividualDTO
       {
           Id = individual.Id,
           Fname = individual.Fname,
       };
}