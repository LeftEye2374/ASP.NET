using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseWelcomePage();

app.Run();

