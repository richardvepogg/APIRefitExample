using ProductRefitService.Controllers;
using Microsoft.OpenApi.Models;
using ProductRefitService.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.RegisterDependencies();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "APIRefit", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
});

app.UseAuthorization();

app.MapControllers();
app.ConfigureApi();
app.Run();
