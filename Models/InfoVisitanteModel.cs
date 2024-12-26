namespace RegistroVisitantes.Models;

public class  InfoVisitante{

    public int?  Id {get; set;}
    public DateTime? Fecha {get; set;}
    public string? Nombre { get; set; } 
    public string? Sexo {get; set;}
    public int? EdadVisitantes {get; set;}

    public string? Identificacion {get; set;}

    public string? Email {get; set;}

    public int? NumeroTelefono {get; set;}

    public string? Nacionalidad {get; set;}

    public string? PaisDeOrigen { get; set; }

}

