using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapGet("/", () => "Helllo world");

app.Run();

