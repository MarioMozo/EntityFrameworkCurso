using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoef;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<TareasContextcs>( p => p.UseInMemoryDatabase("TareasBD"));
builder.Services.AddSqlServer<TareasContextcs>(builder.Configuration.GetConnectionString("cnTareas"));
//Trusted_Connection=True; TrustServerCertificate=True; --> Error de conexión, se agregaron dos comandos de confiabilidad
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async([FromServices] TareasContextcs dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Bases de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.Run();
