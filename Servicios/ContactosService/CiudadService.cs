using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class CiudadService 
{
    
    CiudadDatos ciudadD;
    
    public CiudadModel ElimCiudad(int id) 
    {
        return ciudadD.ElimCiudad(id);
    }
    
    public CiudadService(string cadenaConexion) 
    {
        ciudadD = new CiudadDatos(cadenaConexion);
    }
    
    public void EditCiudad(CiudadModel ciudad) 
    {
        ciudadD.EditCiudad(ciudad);
    }  
    
    public List<CiudadModel> obtenerCiudades()
    {
        return ciudadD.obtenerCiudades();
    }

    
    public CiudadModel obtenerDatosCiudad(int id) 
    {
        return ciudadD.obtenerDatosCiudad(id);
    }

    
    public void insertCiudad(CiudadModel ciudad) {
        ciudadD.insertCiudad(ciudad);
    }
    


    
}