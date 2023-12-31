namespace Infraestructura.Modelos;

public class UsuarioModel
{
    public int id_usuario { get; set; }
    public string estado { get; set; }
    public PersonaModel persona { get; set; }
    public string nivel { get; set; }
    public int id_persona { get; set; }
    public string nombre_usuario { get; set; }
    public string contrasena { get; set; }
}