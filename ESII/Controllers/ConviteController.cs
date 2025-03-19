using Microsoft.AspNetCore.Mvc;
using ESII.Models;
using Microsoft.EntityFrameworkCore;
[Route("api/[controller]")]
[ApiController]
public class ConviteController : ControllerBase
{
    private readonly ConviteService _service;

    public ConviteController(ConviteService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Convite>>> GetConvites()
    {
        return await _service.ObterTodos();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Convite>> GetConvite(int id)
    {
        var convite = await _service.ObterPorId(id);
        if (convite == null) return NotFound();
        return convite;
    }

    [HttpPost]
    public async Task<IActionResult> PostConvite(Convite convite)
    {
        await _service.Adicionar(convite);
        return CreatedAtAction(nameof(GetConvite), new { id = convite.Id }, convite);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutConvite(int id, Convite convite)
    {
        if (id != convite.Id) return BadRequest();
        await _service.Atualizar(convite);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteConvite(int id)
    {
        await _service.Remover(id);
        return NoContent();
    }
}