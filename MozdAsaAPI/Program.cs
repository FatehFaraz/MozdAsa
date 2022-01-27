using Microsoft.EntityFrameworkCore;
using MozdAsa.Data.Context;
using MozdAsa.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigurationManager configuration = builder.Configuration;
var container = new ServiceCollection();

builder.Services.AddDbContext<MozdAsaDbContext>(options => 
    options.UseSqlServer(configuration.GetConnectionString("MozdAsaDbConection")));
//RegisterServices(services);
builder.Services.AddControllers();
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


