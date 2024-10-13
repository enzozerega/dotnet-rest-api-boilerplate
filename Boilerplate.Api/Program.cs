using Boilerplate.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterServices();

var app = builder.Build();

app.RegisterMiddlewares();
app.UseHttpsRedirection();
app.RegisterHealthCheckEndpoint();


app.Run();
