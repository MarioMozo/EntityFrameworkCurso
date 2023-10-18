using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoef;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TareasContextcs>( p => p.UseInMemoryDatabase("TareasBD"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async([FromServices] TareasContextcs dbContext) =>{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Bases de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.Run();
