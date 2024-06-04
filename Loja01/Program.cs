using Microsoft.EntityFrameworkCore;
using Loja01.Project.Domain.Repository;
using Loja01.Project.Database;
using Loja01.Project.Domain.Infrastructure.Facade;
using Loja01.Project.Infrastructure.Facade;
using Loja01.Project.Domain.Repository.Interfaces;
using Loja01.Project.Domain.Infrastructure.Service;
using Loja01.Project.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Adicionar servi�os ao cont�iner
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Reposit�rios
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<ICarrinhoRepository, CarrinhoRepository>();
builder.Services.AddScoped<ICarrinhoItensRepository, CarrinhoItensRepository>();

// Facades
builder.Services.AddScoped<IProdutoFacade, ProdutoFacade>();
builder.Services.AddScoped<IClienteFacade, ClienteFacade>();
builder.Services.AddScoped<ICarrinhoFacade, CarrinhoFacade>();

// Servi�os
builder.Services.AddScoped<IAddItemService, AddItemService>();

// Configura��o do banco de dados
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
