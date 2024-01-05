using Microsoft.EntityFrameworkCore;
using ProEventos.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

////aqui codigo que nao tenho que decorar
builder.Services.AddDbContext<DataContext>(options => /*configura o contexto do Entity Framework Core para interagir com o banco de dados.*/
options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoSQL"))); /*configura o contexto do Entity Framework Core para interagir com o banco de dados.*/
////aqui codigo que nao tenho que decorar



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
