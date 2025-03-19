using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ESII.Models;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class TarefaController : ControllerBase
{
    private readonly TarefaService _service;

    public TarefaController(TarefaService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Tarefa>>> GetTarefas()
    {
        return await _service.ObterTodos();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Tarefa>> GetTarefa(int id)
    {
        var tarefa = await _service.ObterPorId(id);
        if (tarefa == null) return NotFound();
        return tarefa;
    }

    [HttpPost]
    public async Task<IActionResult> PostTarefa(Tarefa tarefa)
    {
        await _service.Adicionar(tarefa);
        return CreatedAtAction(nameof(GetTarefa), new { id = tarefa.Id }, tarefa);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTarefa(int id, Tarefa tarefa)
    {
        if (id != tarefa.Id) return BadRequest();
        await _service.Atualizar(tarefa);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTarefa(int id)
    {
        await _service.Remover(id);
        return NoContent();
    }
}