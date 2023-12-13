using Microsoft.AspNetCore.Mvc;
using Servicios.ContactosService;

namespace Ariel_API.Controllers;

[ApiController]
[Route("[controller]")]

public class CiudadController : ControllerBase {
    
    private const string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=1313;Database=ExamenFinalDB;";
    private CiudadService servicio;

    public CiudadController() {
        servicio = new CiudadService(connectionString);
    }
    
    
    [HttpDelete("{id}")]
    public IActionResult ElimCiudad(int id)
    {
        return Ok(servicio.ElimCiudad(id));
    }

    [HttpPost]
    public IActionResult insertCiudad([FromBody] Infraestructura.Modelos.CiudadModel ciudad) {
        servicio.insertCiudad(ciudad);
        return Created("", ciudad);
    }
    
    [HttpGet("{id}")]
    public IActionResult obtenerDatosCiudad([FromQuery] int id) {
        var ciudad = servicio.obtenerDatosCiudad(id);
        return Ok(ciudad);
    }
    /*
    [HttpPut]
    public IActionResult EditCiudad([FromBody] Infraestructura.Modelos.CiudadModel ciudad) {
        try {
            servicio.EditCiudad(ciudad);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
            throw;
        }
        return Ok();
    }*/

    [HttpGet]
    public IActionResult obtenerCiudades()
    {
        return Ok(servicio.obtenerCiudades());
    }
    
  
    
 

}