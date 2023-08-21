using DevFreela.Application.Commands.CreateProject;
using DevFreela.Application.Services.Implementations;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<DevFreelaDbContext>();

var connectionString = builder.Configuration.GetConnectionString("DevFreelaCs");
builder.Services.AddDbContext<DevFreelaDbContext>(p => p.UseSqlServer(connectionString));

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddMediatR(typeof(CreateProjectCommand));

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
