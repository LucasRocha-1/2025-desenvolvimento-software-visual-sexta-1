var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "minha primeira API");

app.Run();
