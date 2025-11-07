var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "as1Èö´óËÕ´ò");

app.Run();
