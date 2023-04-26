using _1er_Parcial_BlasServin_Optativo4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace _1er_Parcial_BlasServin_Optativo4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CiudadController : Controller
    {
        private CiudadService ciudadService;
        private IConfiguration configuration;
        public CiudadController(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.ciudadService = new CiudadService(configuration.GetConnectionString("postgresDB"));
        }

        [HttpGet("ListarCiudad")]
        public ActionResult<List<CiudadModel>> ListarCiudads()
        {
            var resultado = ciudadService.listarCiudad();
            return Ok(resultado);
        }

        [HttpGet("ConsultarCiudad/{id}")]
        public ActionResult<CiudadModel> ConsultarCiudad(int id)
        {
            var resultado = this.ciudadService.consultarCiudad(id);
            return Ok(resultado);
        }

        [HttpPost("InsertarCiudad")]
        public ActionResult<string> insertarCiudad(CiudadModel modelo)
        {
            var resultado = this.ciudadService.insertarCiudad(new infraestructure.Models.CiudadModel
            {
                Ciudad = modelo.Ciudad,
                Estado = modelo.Estado
            });
            return Ok(resultado);
        }

        [HttpPut("ModificarCiudad/{id}")]
        public ActionResult<string> modificarCiudad(CiudadModel modelo, int id)
        {
            var resultado = this.ciudadService.modificarCiudad(new infraestructure.Models.CiudadModel
            {
                Ciudad = modelo.Ciudad,
                Estado = modelo.Estado
            }, id);
            return Ok(resultado);
        }

        [HttpDelete("EliminarCiudad/{id}")]
        public ActionResult<string> eliminarCiudad(int id)
        {
            var resultado = this.ciudadService.eliminarCiudad(id);
            return Ok(resultado);
        }
    }
}
