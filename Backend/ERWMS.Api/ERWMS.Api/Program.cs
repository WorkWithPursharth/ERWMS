using ERWMS.Api.Middlewares;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Log.Logger = new LoggerConfiguration()
	.WriteTo.Console()
	.WriteTo.File("Logs/log-.txt", rollingInterval: RollingInterval.Day)
	.CreateLogger();

builder.Host.UseSerilog();

var app = builder.Build();
app.UseMiddleware<GlobalExceptionMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
