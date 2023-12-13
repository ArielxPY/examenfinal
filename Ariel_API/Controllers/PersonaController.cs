using Microsoft.AspNetCore.Mvc;
using Servicios.ContactosService;

namespace Ariel_API.Controllers;
[ApiController]
[Route("[controller]")]
public class PersonaController : Controller {
    
    private PersonaService personaServicio;

    public PersonaController()
    {
        personaServicio = new PersonaService("Server=localhost;Port=5432;User Id=postgres;Password=1313;Database=ExamenFinalDB;");
    }
    
    [HttpDelete("{id}")]
    public IActionResult ElimPersona(int id)
    {
        return Ok(personaServicio.ElimPersona(id));
    }
    
    [HttpPut]
    public IActionResult EditPersona([FromBody] Infraestructura.Modelos.PersonaModel modelo) {
        try {
            personaServicio.EditPersona(modelo);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
            throw;
        }
        return Ok();
    }
    
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(personaServicio.obtenerDatosPersona(id));
    }

      
    [HttpGet]
    public IActionResult obtenerPersonas()
    {
        return Ok(personaServicio.obtenerPersonas());
    }
    
    /*
    [HttpPost]
    public IActionResult insertPersona([FromBody] Models.PersonaModels modelo)
    {
        personaServicio.insertPersona(
            new Infraestructura.Modelos.PersonaModel
            {
                nombre = modelo.nombre,
                apellido = modelo.apellido,
                nro_documento = modelo.nro_documento,
                direccion = modelo.direccion,
                email = modelo.email,
                celular = modelo.celular,
                estado = modelo.estado,
                ciudad  = new Infraestructura.Modelos.CiudadModel
                {
                    id_ciudad = modelo.id_ciudad
                }
            });
        return Ok();
    } */
  
    
}