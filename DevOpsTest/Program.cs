var builder = WebApplication.CreateBuilder(args);

Console.WriteLine("This is only on the development branch");

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
