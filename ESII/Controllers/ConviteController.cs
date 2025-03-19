using Microsoft.AspNetCore.Mvc;  // Importa funcionalidades MVC
using System.Collections.Generic;  // Permite listas
using System.Threading.Tasks;  // Habilita métodos assíncronos
using ESII.Models;  // Referência os modelos



[ApiController]  
[Route("api/convites")]  // Define a rota base para a API  
public class ConviteController : ControllerBase  
{  
    private readonly ConviteService _service;

    public ConviteController(ConviteService service)  
    {  
        _service = service;  
    }

    [HttpGet]  
    public async Task<ActionResult<List<Convite>>> GetConvites()  
    {  
        return await _service.ObterTodos();  
    }  

    [HttpGet("{id}")]  
    public async Task<ActionResult<Convite>> GetConvite(int id)  
    {  
        var convite = await _service.ObterPorId(id);  
        if (convite == null) return NotFound();  
        return convite;  
    }  

    [HttpPost]  
    public async Task<IActionResult> PostConvite(Convite convite)  
    {  
        await _service.Adicionar(convite);  
        return CreatedAtAction(nameof(GetConvite), new { id = convite.Id }, convite);  
    }  

    [HttpDelete("{id}")]  
    public async Task<IActionResult> DeleteConvite(int id)  
    {  
        var convite = await _service.ObterPorId(id);  
        if (convite == null) return NotFound();  

        await _service.Remover(id);  
        return NoContent();  
    }  
}
