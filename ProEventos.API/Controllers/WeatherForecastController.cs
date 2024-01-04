using Microsoft.AspNetCore.Mvc;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
       

        [HttpGet]
        public string Get()
        {
            return "Get";
        }
    }
}
