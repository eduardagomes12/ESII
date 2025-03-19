using ESII.Models;
using Microsoft.EntityFrameworkCore;
public class ProjetoService
{
    private readonly AppDbContext _context;

    public ProjetoService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Projeto>> ObterTodos()
    {
        return await _context.Projetos.ToListAsync();
    }

    public async Task<Projeto?> ObterPorId(int id)
    {
        return await _context.Projetos.FindAsync(id);
    }

    public async Task Adicionar(Projeto projeto)
    {
        _context.Projetos.Add(projeto);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Projeto projeto)
    {
        _context.Projetos.Update(projeto);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(int id)
    {
        var projeto = await _context.Projetos.FindAsync(id);
        if (projeto != null)
        {
            _context.Projetos.Remove(projeto);
            await _context.SaveChangesAsync();
        }
    }
}