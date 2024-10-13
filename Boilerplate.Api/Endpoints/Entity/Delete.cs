using Microsoft.AspNetCore.Http.HttpResults;

namespace Boilerplate.Api.Endpoints.Entity;

public class Delete
{
	public static async Task<NoContent> Handler(string Id)
	{
		return TypedResults.NoContent();
	}
}
