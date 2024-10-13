using System.ComponentModel.DataAnnotations;

namespace Boilerplate.Api.Dtos.Entity;

public record class CreateEntityDto(
	[Required] string Field
);