using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ContactosService;

public class UsuarioService
{
    UsuarioDatos usuarioDatos;


    
    public void insertUsuario(UsuarioModel usuario)
    {
        usuarioDatos.insertUsuario(usuario);
    }
    
    public UsuarioModel obtenerUser(string username)
    {
        return usuarioDatos.obtenerUser(username);
    }
    public void EditUsuario(UsuarioModel usuario)
    {
        usuarioDatos.EditUsuario(usuario);
    }  
    
    public UsuarioModel ElimiUsuario(int id) {
        return usuarioDatos.ElimiUsuario(id);
    }
    public UsuarioService(string cadenaConexion) {
        usuarioDatos = new UsuarioDatos(cadenaConexion);
    }
    
    public List<UsuarioModel> obtenerUsuario()
    {
        return usuarioDatos.obtenerUsuario();
    }
    
    public UsuarioModel obtenerDatosUsuario(int id)
    {
        return usuarioDatos.obtenerDatosUsuario(id);
    }
    

 
    
    
}