using Boilerplate.Api.Dtos.Entity;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Boilerplate.Api.Endpoints.Entity;

public class Get
{
	public static async Task<Ok<EntityDto>> Handler(string id)
	{
		EntityDto entity = new(id, "Field");

		return TypedResults.Ok(entity);
	}
}
