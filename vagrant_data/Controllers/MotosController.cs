using Microsoft.AspNetCore.Mvc;

namespace MotosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotosController : ControllerBase
    {
        private static readonly List<Moto> Motos = new()
        {
            new Moto { Id = 1, Modelo = "CB 500F", Marca = "Honda" },
            new Moto { Id = 2, Modelo = "MT-03", Marca = "Yamaha" }
        };

        [HttpGet]
        public IActionResult GetMotos() 
        {
            return Ok(Motos);
        }
        [HttpPost]
        public IActionResult AddMoto(Moto moto)
        {
            Motos.Add(moto);
            return CreatedAtAction(nameof(GetMotos), new { id = moto.Id }, moto);
        }
    }
}
