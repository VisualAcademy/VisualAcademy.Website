var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "안녕하세요!");

app.Run();
