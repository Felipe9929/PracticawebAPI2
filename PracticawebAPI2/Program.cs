using Microsoft.EntityFrameworkCore;
using PracticawebAPI2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//Inyecci�n por dependencia del string  de conexi�n al contexto
builder.Services.AddDbContext<equipos2Context>(options =>
        options.UseSqlServer(
               builder.Configuration.GetConnectionString("equipos2DbConnection")
               )
        );
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
