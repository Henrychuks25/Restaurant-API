using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Entities.Models;
using RestaurantAPI.Extensions;
using RestaurantAPI.Repository.Interface;
using RestaurantAPI.Repository.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureCors();
builder.Services.ConfigureIISintegration();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureAutoMapper();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFoodRepo, FoodService>();
builder.Services.AddScoped<IEmployeeRepo, EmployeeService>();
builder.Services.AddScoped<IJobRepo, JobService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
