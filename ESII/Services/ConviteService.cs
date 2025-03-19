using Microsoft.EntityFrameworkCore;
using ESII.Models;

public class ConviteService
{
    private readonly AppDbContext _context;

    public ConviteService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Convite>> ObterTodos()
    {
        return await _context.Convites.ToListAsync();
    }

    public async Task<Convite?> ObterPorId(int id)
    {
        return await _context.Convites.FindAsync(id);
    }

    public async Task Adicionar(Convite convite)
    {
        _context.Convites.Add(convite);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Convite convite)
    {
        _context.Convites.Update(convite);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(int id)
    {
        var convite = await _context.Convites.FindAsync(id);
        if (convite != null)
        {
            _context.Convites.Remove(convite);
            await _context.SaveChangesAsync();
        }
    }
}