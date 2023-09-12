using AuthenticationModule.Data.DTOs;
using AuthenticationModule.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace AuthenticationModule.Services
{
	public class UsuarioService : IUsuarioService
	{
		private IMapper _mapper;
		private UserManager<Usuario> _userManager;

		public UsuarioService(IMapper mapper, UserManager<Usuario> userManager)
		{
			_mapper = mapper;
			_userManager = userManager;
		}

		public async Task<bool> CadastrarUsuario(CreateUsuarioDTO usuarioDTO)
		{
			var usuario = _mapper.Map<Usuario>(usuarioDTO);

			var result = await _userManager.CreateAsync(usuario, usuarioDTO.Password);

			return result.Succeeded;
		}
	}
}
