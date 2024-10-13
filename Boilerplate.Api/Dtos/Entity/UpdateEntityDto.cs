using System.ComponentModel.DataAnnotations;

namespace Boilerplate.Api.Dtos.Entity;

public record class UpdateEntityDto(
	[Required] string Field
);