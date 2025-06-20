using MVC_Project.Models.Repository;
using MVC_Project.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<IClientRepository, ClientRepository>();
builder.Services.AddSingleton<ClientService>();
builder.Services.AddControllers();

var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.Run();