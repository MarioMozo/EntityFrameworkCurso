using Microsoft.EntityFrameworkCore;
using proyectoef.Models;

namespace proyectoef;

public class TareasContextcs: DbContext
{
    public DbSet<Categoria> Categorias{get;set;}
    public DbSet<Tareacscs> Tareas{get;set;}
    public TareasContextcs(DbContextOptions<TareasContextcs> options): base(options){

    }
}