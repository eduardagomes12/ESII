using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ESII.Models;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class UtilizadorProjetoController : ControllerBase
{
    private readonly UtilizadorProjetoService _service;

    public UtilizadorProjetoController(UtilizadorProjetoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<UtilizadorProjeto>>> GetUtilizadorProjetos()
    {
        return await _service.ObterTodos();
    }

    [HttpGet("{utilizadorId}/{projetoId}")]
    public async Task<ActionResult<UtilizadorProjeto>> GetUtilizadorProjeto(int utilizadorId, int projetoId)
    {
        var utilizadorProjeto = await _service.ObterPorId(utilizadorId, projetoId);
        if (utilizadorProjeto == null) return NotFound();
        return utilizadorProjeto;
    }

    [HttpPost]
    public async Task<IActionResult> PostUtilizadorProjeto(UtilizadorProjeto utilizadorProjeto)
    {
        await _service.Adicionar(utilizadorProjeto);
        return CreatedAtAction(nameof(GetUtilizadorProjeto), new { utilizadorId = utilizadorProjeto.UtilizadorId, projetoId = utilizadorProjeto.ProjetoId }, utilizadorProjeto);
    }

    [HttpDelete("{utilizadorId}/{projetoId}")]
    public async Task<IActionResult> DeleteUtilizadorProjeto(int utilizadorId, int projetoId)
    {
        await _service.Remover(utilizadorId, projetoId);
        return NoContent();
    }
}