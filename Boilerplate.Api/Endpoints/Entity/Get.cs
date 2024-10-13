using Boilerplate.Api.Dtos.Entity;

namespace Boilerplate.Api.Endpoints.Entity;

public class Get
{
	public static IResult Handler(string id)
	{
		EntityDto entity = new(id, "Field");

		return TypedResults.Ok(entity);
	}
}
