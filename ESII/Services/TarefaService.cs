using ESII.Models;
using Microsoft.EntityFrameworkCore;
public class TarefaService
{
    private readonly AppDbContext _context;

    public TarefaService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Tarefa>> ObterTodos()
    {
        return await _context.Tarefas.ToListAsync();
    }

    public async Task<Tarefa?> ObterPorId(int id)
    {
        return await _context.Tarefas.FindAsync(id);
    }

    public async Task Adicionar(Tarefa tarefa)
    {
        _context.Tarefas.Add(tarefa);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Tarefa tarefa)
    {
        _context.Tarefas.Update(tarefa);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(int id)
    {
        var tarefa = await _context.Tarefas.FindAsync(id);
        if (tarefa != null)
        {
            _context.Tarefas.Remove(tarefa);
            await _context.SaveChangesAsync();
        }
    }
}