using Boilerplate.Api.Dtos.Entity;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Boilerplate.Api.Endpoints.Entity;


public class Update
{
	public static async Task<NoContent> Handler(string Id, UpdateEntityDto Payload)
	{
		return TypedResults.NoContent();
	}
}
