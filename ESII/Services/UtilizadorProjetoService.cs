using ESII.Models;
using Microsoft.EntityFrameworkCore;
public class UtilizadorProjetoService
{
    private readonly AppDbContext _context;

    public UtilizadorProjetoService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<UtilizadorProjeto>> ObterTodos()
    {
        return await _context.UtilizadoresProjetos.ToListAsync();
    }

    public async Task<UtilizadorProjeto?> ObterPorId(int utilizadorId, int projetoId)
    {
        return await _context.UtilizadoresProjetos.FindAsync(utilizadorId, projetoId);
    }

    public async Task Adicionar(UtilizadorProjeto utilizadorProjeto)
    {
        _context.UtilizadoresProjetos.Add(utilizadorProjeto);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(int utilizadorId, int projetoId)
    {
        var utilizadorProjeto = await _context.UtilizadoresProjetos.FindAsync(utilizadorId, projetoId);
        if (utilizadorProjeto != null)
        {
            _context.UtilizadoresProjetos.Remove(utilizadorProjeto);
            await _context.SaveChangesAsync();
        }
    }
}