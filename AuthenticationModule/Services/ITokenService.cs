using AuthenticationModule.Models;

namespace AuthenticationModule.Services
{
	public interface ITokenService
	{
		string GenerateToken(Usuario usuario);
	}
}
