namespace Boilerplate.Api.Endpoints.Entity;

public static class Routes
{
	public static void RegisterEntityRoutes(this WebApplication app)
	{
		RouteGroupBuilder group = app.MapGroup("/entity").WithParameterValidation();

		group.MapGet("/", List.Handler);
		group.MapGet("/{id}", Get.Handler).WithName("GetEntity");
		group.MapPost("/", Create.Handler);
		group.MapPut("/{id}", Update.Handler);
		group.MapDelete("/{id}", Delete.Handler);
	}
}