using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento()
        {
            EventoId = 1,
            Tema = "Angular 11 e .Net 8",
            Local = "Brasília",
            Lote = "1º Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd-MM-yyyy"), // Formato ISO 8601
            ImagemURL = "foto.png" // Certifique-se de que esta imagem existe no projeto
        },
        new Evento()
              {
                EventoId = 2,
                Tema = "Angular 11 e .Net 8 e suas novidades",
                Local = "Rio de Janeiro",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd-MM-yyyy"), // Formato ISO 8601
                ImagemURL = "foto1.png" // Certifique-se de que esta imagem existe no projeto
              }
        };
        





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
}
