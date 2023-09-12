using AuthenticationModule.Data.DTOs;

namespace AuthenticationModule.Services
{
	public interface IUsuarioService
	{
		Task<bool> CadastrarUsuario(CreateUsuarioDTO usuarioDTO);
	}
}
