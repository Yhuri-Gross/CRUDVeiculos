using Microsoft.AspNetCore.Mvc;
using CrudVeiculos.Data;
using CrudVeiculos.Models;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class VeiculosController : ControllerBase
{
    private readonly AppDbContext _context;

    public VeiculosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Veiculo>>> GetVeiculos()
    {
        return await _context.Veiculos.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Veiculo>> GetVeiculo(int id)
    {
        var veiculo = await _context.Veiculos.FindAsync(id);
        if (veiculo == null) return NotFound();
        return veiculo;
    }

    [HttpPost]
    public async Task<ActionResult<Veiculo>> PostVeiculo(Veiculo veiculo)
    {
        _context.Veiculos.Add(veiculo);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetVeiculo), new { id = veiculo.Id }, veiculo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutVeiculo(int id, Veiculo veiculo)
    {
        if (id != veiculo.Id) return BadRequest();
        _context.Entry(veiculo).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteVeiculo(int id)
    {
        var veiculo = await _context.Veiculos.FindAsync(id);
        if (veiculo == null) return NotFound();
        _context.Veiculos.Remove(veiculo);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
