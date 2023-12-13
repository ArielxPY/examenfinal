namespace Infraestructura.Modelos;

public class ClienteModel
{
    public string estado { get; set; }
    public  PersonaModel persona { get; set; }

    public string calificacion { get; set; }
    
    public int id_cliente { get; set; }

    public DateTime fecha_ingreso { get; set; }



}