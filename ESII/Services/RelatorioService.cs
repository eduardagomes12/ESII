using ESII.Models;
using Microsoft.EntityFrameworkCore;
public class RelatorioService
{
    private readonly AppDbContext _context;

    public RelatorioService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Relatorio>> ObterTodos()
    {
        return await _context.Relatorios.ToListAsync();
    }

    public async Task<Relatorio?> ObterPorId(int id)
    {
        return await _context.Relatorios.FindAsync(id);
    }

    public async Task Adicionar(Relatorio relatorio)
    {
        _context.Relatorios.Add(relatorio);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Relatorio relatorio)
    {
        _context.Relatorios.Update(relatorio);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(int id)
    {
        var relatorio = await _context.Relatorios.FindAsync(id);
        if (relatorio != null)
        {
            _context.Relatorios.Remove(relatorio);
            await _context.SaveChangesAsync();
        }
    }
}