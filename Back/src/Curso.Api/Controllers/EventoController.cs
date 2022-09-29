using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Curso.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        private IEnumerable<Evento> _eventos = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "dotnet and android",
                Local = "BA",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImageURL = "https://www.img2.com"
            }, 
            new Evento() {
                EventoId = 2,
                Tema = "dotnet and ios",
                Local = "SP",
                Lote = "2º lote",
                QtdPessoas = 150,
                DataEvento = DateTime.Now.AddDays(5).ToString(),
                ImageURL = "https://www.phone.com"
            }
        };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _eventos.Where(x => x.EventoId == id);
        }
    }
}
