using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ESII.Models;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class UtilizadorController : ControllerBase
{
    private readonly UtilizadorService _service;

    public UtilizadorController(UtilizadorService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Utilizador>>> GetUtilizadores()
    {
        return await _service.ObterTodos();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Utilizador>> GetUtilizador(int id)
    {
        var utilizador = await _service.ObterPorId(id);
        if (utilizador == null) return NotFound();
        return utilizador;
    }

    [HttpPost]
    public async Task<IActionResult> PostUtilizador(Utilizador utilizador)
    {
        await _service.Adicionar(utilizador);
        return CreatedAtAction(nameof(GetUtilizador), new { id = utilizador.Id }, utilizador);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutUtilizador(int id, Utilizador utilizador)
    {
        if (id != utilizador.Id) return BadRequest();
        await _service.Atualizar(utilizador);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUtilizador(int id)
    {
        await _service.Remover(id);
        return NoContent();
    }
}