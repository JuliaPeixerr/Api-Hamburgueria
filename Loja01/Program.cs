using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Loja01.Project.Domain.Repository;
using Loja01.Project.Database;
using Loja01.Project.API.Controllers;
using Loja01.Project.Domain.Infrastructure.Facade;
using Loja01.Project.Infrastructure.Facade;
using Loja01.Project.Domain.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//repositories
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

//facades
builder.Services.AddScoped<IProdutoFacade, ProdutoFacade>();
builder.Services.AddScoped<IClienteFacade, ClienteFacade>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ProjectContext>(op => op.UseSqlite(connectionString));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();
app.UseHttpsRedirection();
app.Run();
