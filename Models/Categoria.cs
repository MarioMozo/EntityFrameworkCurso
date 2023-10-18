using System.ComponentModel.DataAnnotations;

namespace proyectoef.Models;

public class Categoria
{
    [Key]
    public Guid CategoriaId{get;set;}   //Representa un identificador único global (GUID)
    [Required]
    [MaxLength(150)]
    public string Nombre{get;set;}
    public string Descripcion{get;set;}
 
}
