using ESII.Models;
using Microsoft.EntityFrameworkCore;

public class ClienteService

{
    private readonly AppDbContext _context;

    public ClienteService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Cliente>> ObterTodos()
    {
        return await _context.Clientes.ToListAsync();
    }

    public async Task<Cliente?> ObterPorId(int id)
    {
        return await _context.Clientes.FindAsync(id);
    }

    public async Task Adicionar(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Cliente cliente)
    {
        _context.Clientes.Update(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);
        if (cliente != null)
        {
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
        }
    }
}