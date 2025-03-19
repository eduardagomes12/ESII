using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ESII.Models;

[Route("api/[controller]")]
[ApiController]
public class RelatorioProjController : ControllerBase
{
    private readonly RelatorioProjService _service;

    public RelatorioProjController(RelatorioProjService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<RelatorioProj>>> GetRelatorioProjs()
    {
        return await _service.ObterTodos();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<RelatorioProj>> GetRelatorioProj(int id)
    {
        var relatorioProj = await _service.ObterPorId(id);
        if (relatorioProj == null) return NotFound();
        return relatorioProj;
    }

    [HttpPost]
    public async Task<IActionResult> PostRelatorioProj(RelatorioProj relatorioProj)
    {
        await _service.Adicionar(relatorioProj);
        return CreatedAtAction(nameof(GetRelatorioProj), new { id = relatorioProj.Id }, relatorioProj);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutRelatorioProj(int id, RelatorioProj relatorioProj)
    {
        if (id != relatorioProj.Id) return BadRequest();
        await _service.Atualizar(relatorioProj);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRelatorioProj(int id)
    {
        await _service.Remover(id);
        return NoContent();
    }
}