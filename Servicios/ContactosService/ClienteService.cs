using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class ClienteService 
{
    
    ClienteDatos clienteD;

      
    public ClienteModel ElimCliente(int id) 
    {
        return clienteD.ElimCliente(id);
    }
    
    public ClienteModel obtenerDatosCliente(int id) 
    {
        return clienteD.obtenerDatosCliente(id);
    }

    public void insertCliente(ClienteModel cliente)
    {
        clienteD.insertCliente(cliente);
    }
    
    public ClienteService(string cadenaConexion)
    {
        clienteD = new ClienteDatos(cadenaConexion);
    }

    public List<ClienteModel> obtenerClientes()
    {
        return clienteD.obtenerClientes();
    }

    public void editCliente(ClienteModel cliente) 
    {
        clienteD.editCliente(cliente);
    } 
       


}