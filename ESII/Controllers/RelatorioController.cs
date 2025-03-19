using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ESII.Models;
using Microsoft.EntityFrameworkCore;
[Route("api/[controller]")]
[ApiController]
public class RelatorioController : ControllerBase
{
    private readonly RelatorioService _service;

    public RelatorioController(RelatorioService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Relatorio>>> GetRelatorios()
    {
        return await _service.ObterTodos();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Relatorio>> GetRelatorio(int id)
    {
        var relatorio = await _service.ObterPorId(id);
        if (relatorio == null) return NotFound();
        return relatorio;
    }

    [HttpPost]
    public async Task<IActionResult> PostRelatorio(Relatorio relatorio)
    {
        await _service.Adicionar(relatorio);
        return CreatedAtAction(nameof(GetRelatorio), new { id = relatorio.Id }, relatorio);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutRelatorio(int id, Relatorio relatorio)
    {
        if (id != relatorio.Id) return BadRequest();
        await _service.Atualizar(relatorio);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRelatorio(int id)
    {
        await _service.Remover(id);
        return NoContent();
    }
}