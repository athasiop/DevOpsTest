var builder = WebApplication.CreateBuilder(args);

Console.WriteLine("Amazing Change 2");

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
