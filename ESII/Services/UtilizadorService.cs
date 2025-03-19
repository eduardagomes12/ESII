using ESII.Models;
using Microsoft.EntityFrameworkCore;
public class UtilizadorService
{
    private readonly AppDbContext _context;

    public UtilizadorService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Utilizador>> ObterTodos()
    {
        return await _context.Utilizadores.ToListAsync();
    }

    public async Task<Utilizador?> ObterPorId(int id)
    {
        return await _context.Utilizadores.FindAsync(id);
    }

    public async Task Adicionar(Utilizador utilizador)
    {
        _context.Utilizadores.Add(utilizador);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Utilizador utilizador)
    {
        _context.Utilizadores.Update(utilizador);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(int id)
    {
        var utilizador = await _context.Utilizadores.FindAsync(id);
        if (utilizador != null)
        {
            _context.Utilizadores.Remove(utilizador);
            await _context.SaveChangesAsync();
        }
    }
}