using MultiStoreAPI.Domain.Data;

var builder = WebApplication.CreateBuilder(args);

var env = builder.Environment.EnvironmentName ?? "Development";

builder.Configuration.AddJsonFile("appsettings.json", true, true);
builder.Configuration.AddJsonFile($"appsettings.{env}.json", optional: false, reloadOnChange: true);
builder.Configuration.AddEnvironmentVariables();

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
