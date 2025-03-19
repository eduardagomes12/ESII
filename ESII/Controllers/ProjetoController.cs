using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ESII.Models;
using Microsoft.EntityFrameworkCore;
[Route("api/[controller]")]
[ApiController]
public class ProjetoController : ControllerBase
{
    private readonly ProjetoService _service;

    public ProjetoController(ProjetoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Projeto>>> GetProjetos()
    {
        return await _service.ObterTodos();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Projeto>> GetProjeto(int id)
    {
        var projeto = await _service.ObterPorId(id);
        if (projeto == null) return NotFound();
        return projeto;
    }

    [HttpPost]
    public async Task<IActionResult> PostProjeto(Projeto projeto)
    {
        await _service.Adicionar(projeto);
        return CreatedAtAction(nameof(GetProjeto), new { id = projeto.Id }, projeto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutProjeto(int id, Projeto projeto)
    {
        if (id != projeto.Id) return BadRequest();
        await _service.Atualizar(projeto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProjeto(int id)
    {
        await _service.Remover(id);
        return NoContent();
    }
}