using Microsoft.AspNetCore.Mvc;
using ProEventos1.API.Data;
using ProEventos1.API.Models;

namespace ProEventos1.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventosController : ControllerBase
{

    private readonly DataContext _context;
    public EventosController(DataContext context)
    {
        this._context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
        return _context.Eventos.FirstOrDefault(
            evento => evento.EventoId == id);

    }
}
