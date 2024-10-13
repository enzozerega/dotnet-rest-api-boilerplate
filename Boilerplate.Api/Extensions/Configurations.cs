namespace Boilerplate.Api.Extensions

{
	public static class Configuration
	{
		public static void RegisterServices(this WebApplicationBuilder builder)
		{
			builder.Services
				   .AddEndpointsApiExplorer()
				   .AddSwaggerGen();
		}

		public static void RegisterMiddlewares(this WebApplication app)
		{
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger()
				   .UseSwaggerUI();
			}

			app.UseHttpsRedirection();
		}

		public static void RegisterHealthCheckEndpoint(this WebApplication app)
		{
			app.MapGet("/health", () => "Pong").WithOpenApi(operation => new(operation)
			{
				Summary = "Health check for the API",
				Description = "Returns a simple pong response to indicate the API is up and running"
			}
			);
		}
	}
}