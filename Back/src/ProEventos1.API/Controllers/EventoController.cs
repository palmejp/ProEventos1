using Microsoft.AspNetCore.Mvc;
using ProEventos1.API.Models;

namespace ProEventos1.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1� Lote",
                QtdPessoas = 150,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"
            },
            new Evento()
            {
                EventoId = 2,
                Tema = "Angular e suas novidades",
                Local = "S�o Paulo",
                Lote = "2� Lote",
                QtdPessoas = 50,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto1.png"
            }
        };


    public EventoController()
    {
        
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);

    }
}
