using Boilerplate.Api.Dtos.Entity;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Boilerplate.Api.Endpoints.Entity;

public class List
{
	public static async Task<Ok<List<EntityDto>>> Handler()
	{
		List<EntityDto> items = [];

		return TypedResults.Ok(items);
	}

}
