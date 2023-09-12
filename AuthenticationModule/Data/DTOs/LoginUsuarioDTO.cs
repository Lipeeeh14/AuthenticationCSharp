using System.ComponentModel.DataAnnotations;

namespace AuthenticationModule.Data.DTOs
{
	public record LoginUsuarioDTO
	{
        [Required]
        public string Username { get; init; }

		[Required]
		public string Password { get; init; }
	}
}
