using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[] {
             new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "Https://www.google.com/img.jpg"
                },
                new Evento() {
                EventoId = 2,
                Tema = "Javascript e CSS",
                Local = "Viçosa",
                Lote = "2º Lote",
                QtdPessoas = 500,
                DataEvento = DateTime.Now.AddDays(20).ToString("dd/MM/yyyy"),
                ImagemUrl = "img.png"
                },
        };
        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetEventoById(int id)
        {
            return _context.Eventos.Where(evento => evento.EventoId == id); 
        }

        [HttpPost]

        public string Post(string name)
        {
            return $"Método POST: {name}";
        }

        [HttpPut("{id}")]

        public string Put(int id)
        {
            return $"Método PUT: {id}";
        }

        [HttpDelete("{id}")]

        public string Delete(int id)
        {
            return $"Método DELETE: {id}";
        }


    }
}
