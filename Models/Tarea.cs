using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoef.Models;

public class Tarea{
    [Key]   //Se declara el tipo de dato del FrameWork Entity, [Key] es llave primaria
    public Guid TareaId{get;set;}
    [ForeignKey("CategoriaId")]     //Lo mismo con la llave foranea desde donde se relaciona
    public Guid CategoriaId{get;set;}
    [Required]                  //Es requerido, no puede ser null = not null
    [MaxLength(200)]            //Maximo de caracteres 200, no ocupa mas memoria innecesaria 
    public string Titulo{get;set;}
    public string Descripcion{get;set;}
    public Prioridad PrioridadTarea{get;set;}
    public DateTime FechaCreacion{get;set;}
    public virtual Categoria Categoria{get;set;}        //Virtual permite que se herede y se modifique, con public void new ClassVirtual(){+}
    [NotMapped]
    public string Resumen{get;set;}
}

public enum Prioridad
{
    Baja,
    Media,
    Alta,
}