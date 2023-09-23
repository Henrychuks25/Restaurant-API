using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Entities.Models;
using RestaurantAPI.Extensions;
using RestaurantAPI.Repository.Interface;
using RestaurantAPI.Repository.Service;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureCors();
builder.Services.ConfigureIISintegration();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureAutoMapper();
builder.Services.ConfigureApiVersionServices();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
    });
    //.AddNewtonsoftJson(options =>
    //options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});
builder.Services.AddScoped<IFoodRepo, FoodService>();
builder.Services.AddScoped<IEmployeeRepo, EmployeeService>();
builder.Services.AddScoped<IJobRepo, JobService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwagger();
app.UseSwaggerUI((Action<SwaggerUIOptions>)(c =>
{
    c.SwaggerEndpoint("./swagger/v1/swagger.json", "RestaurantAPI");
    c.RoutePrefix = string.Empty;
}));

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
