using Boilerplate.Api.Dtos.Entity;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Boilerplate.Api.Endpoints.Entity;


public class Create
{
	public static async Task<CreatedAtRoute<EntityDto>> Handler(CreateEntityDto payload)
	{
		EntityDto entity = new("Id", payload.Field);

		return TypedResults.CreatedAtRoute(entity, "GetEntity", new { Id = entity.Id });
	}

}
