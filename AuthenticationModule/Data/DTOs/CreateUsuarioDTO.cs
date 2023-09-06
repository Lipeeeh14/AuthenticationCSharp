using System.ComponentModel.DataAnnotations;

namespace AuthenticationModule.Data.DTOs
{
	public record CreateUsuarioDTO
	{
		[Required]
		public string Username { get; init; }

		[Required]
		public DateTime DataNascimento { get; init; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; init; }

		[Required]
		[Compare("Password")]
		public string RePassword { get; init; }
	}
}
