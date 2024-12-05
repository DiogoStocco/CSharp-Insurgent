using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using InsurgencyAPI.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();
builder.Services.AddCors(
    options =>
        options.AddPolicy("Acesso Total",
            configs => configs
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod())
);
var app = builder.Build();

app.MapPost("/personas", ([FromBody] Persona persona,
    [FromServices] AppDataContext ctx) =>
{
    ctx.Personas.Add(persona);
    ctx.SaveChanges();
    return Results.Created("", persona);
});


app.UseCors("Acesso Total");
app.Run();
