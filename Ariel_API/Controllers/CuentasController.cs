using Microsoft.AspNetCore.Mvc;
using Servicios.ContactosService;

namespace Ariel_API.Controllers;
[ApiController]
[Route("api/[controller]")]

public class CuentasController : Controller
{
    private CuentasService cuentasService;
    
    public CuentasController()
    {
        cuentasService = new CuentasService("Server=localhost;Port=5432;User Id=postgres;Password=1313;Database=ExamenFinalDB;");
    }
    
    /*
    [HttpPut]
    public IActionResult EditCuenta([FromBody]  Infraestructura.Modelos.CuentasModel modelo) {
        try {
            cuentasService.EditCuenta(modelo);
        }
        catch (Exception ex) {
            return BadRequest(ex.Message);
            throw;
        }
        return Ok();
        
    }*/
      
    [HttpDelete("{id}")]
    public IActionResult ElimCliente(int id)
    {
        return Ok(cuentasService.ElimCliente(id));
    }
    
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(cuentasService.obtenerDatosCuenta(id));
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(cuentasService.obtenerasCuentas());
    }
    
    [HttpPost]
    public IActionResult insertCuentas([FromBody] Models.CuentasModels modelo)
    {
        cuentasService.insertCuentas(
            new Infraestructura.Modelos.CuentasModel()
            {
                nro_cuenta = modelo.nro_cuenta,
                fecha_alta = modelo.fecha_alta,
                tipo_cuenta = modelo.tipo_cuenta,
                estado = modelo.estado,
                saldo = modelo.saldo,
                nro_contrato = modelo.nro_contrato,
                costo_mantenimiento = modelo.costo_mantenimiento,
                promedio_acreditacion = modelo.promedio_acreditacion,
                moneda = modelo.moneda,
                cliente  = new Infraestructura.Modelos.ClienteModel()
                {
                    id_cliente = modelo.id_cliente
                }
            });
        return Ok();
    }
    
}