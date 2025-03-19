using ESII.Models;
using Microsoft.EntityFrameworkCore;
public class RelatorioProjService
{
    private readonly AppDbContext _context;

    public RelatorioProjService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<RelatorioProj>> ObterTodos()
    {
        return await _context.RelatoriosProjetos.ToListAsync();
    }

    public async Task<RelatorioProj?> ObterPorId(int id)
    {
        return await _context.RelatoriosProjetos.FindAsync(id);
    }

    public async Task Adicionar(RelatorioProj relatorioProj)
    {
        _context.RelatoriosProjetos.Add(relatorioProj);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(RelatorioProj relatorioProj)
    {
        _context.RelatoriosProjetos.Update(relatorioProj);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(int id)
    {
        var relatorioProj = await _context.RelatoriosProjetos.FindAsync(id);
        if (relatorioProj != null)
        {
            _context.RelatoriosProjetos.Remove(relatorioProj);
            await _context.SaveChangesAsync();
        }
    }
}