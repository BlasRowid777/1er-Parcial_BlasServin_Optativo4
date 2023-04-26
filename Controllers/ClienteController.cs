using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using _1er_Parcial_BlasServin_Optativo4.Models;

namespace _1er_Parcial_BlasServin_Optativo4.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ClienteController : Controller
    {
        private ClienteService clienteService;
        private IConfiguration configuration;
        public ClienteController(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.clienteService = new ClienteService(configuration.GetConnectionString("postgresDB"));
        }

        [HttpGet("ListarCliente")]
        public ActionResult<List<ClienteModel>> listarClientes()
        {
            var resultado = clienteService.listarCliente();
            return Ok(resultado);
        }

        [HttpGet("ConsultarCliente/{id}")]
        public ActionResult<ClienteModel> consultarCliente(int id)
        {
            var resultado = this.clienteService.consultarCliente(id);
            return Ok(resultado);
        }

        [HttpPost("InsertarCliente")]
        public ActionResult<string> insertarCliente(ClienteModel modelo)
        {
            var resultado = this.clienteService.insertarCliente(new infraestructure.Models.ClienteModel
            {
                Nombre = modelo.Nombre,
                Apellido = modelo.Apellido,
                Documento = modelo.Documento,
                Telefono = modelo.Telefono,
                Email = modelo.Email,
                FechaNacimiento = modelo.FechaNacimiento,
                IdCiudad = modelo.IdCiudad,
                Nacionalidad = modelo.Nacionalidad
                
                
            }); 
            return Ok(resultado);
        }

        [HttpPut("ModificarCliente/{id}")]
        public ActionResult<string> modificarCliente(ClienteModel modelo, int id)
        {
            var resultado = this.clienteService.modificarCliente(new infraestructure.Models.ClienteModel
            {
                Nombre = modelo.Nombre,
                Apellido = modelo.Apellido,
                Documento = modelo.Documento,
                Telefono = modelo.Telefono,
                Email = modelo.Email,
                FechaNacimiento = modelo.FechaNacimiento,
                IdCiudad = modelo.IdCiudad,
                Nacionalidad = modelo.Nacionalidad

            }, id);
            return Ok(resultado);
        }

        [HttpDelete("EliminarCliente/{id}")]
        public ActionResult<string> eliminarCliente(int id)
        {
            var resultado = this.clienteService.eliminarCliente(id);
            return Ok(resultado);
        }
    }
}
