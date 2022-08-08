var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Minimal APIs
app.MapGet("/", () => "Hello, World!");
app.MapGet("/hello", () => new { Hello = "World" }).WithName("HelloWorldApi");
app.MapGet("/goodbye", () => new { Goodbye = "World" }).WithTags("VisualAcademyDemos");
app.MapGet("/version", () => "1.0");
app.MapGet("/creator", () => "https://github.com/VisualAcademy");

app.Run();
