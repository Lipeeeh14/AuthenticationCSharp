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
		private SignInManager<Usuario> _signInManager;
		private ITokenService _tokenService;

		public UsuarioService(IMapper mapper, UserManager<Usuario> userManager,
			SignInManager<Usuario> signInManager, ITokenService tokenService)
		{
			_mapper = mapper;
			_userManager = userManager;
			_signInManager = signInManager;
			_tokenService = tokenService;
		}

		public async Task<bool> CadastrarUsuario(CreateUsuarioDTO usuarioDTO)
		{
			var usuario = _mapper.Map<Usuario>(usuarioDTO);

			var result = await _userManager.CreateAsync(usuario, usuarioDTO.Password);

			return result.Succeeded;
		}

		public async Task<string> Login(LoginUsuarioDTO loginUsuarioDTO)
		{
			var result = await _signInManager.PasswordSignInAsync(loginUsuarioDTO.Username, loginUsuarioDTO.Password, false, false);

			if (!result.Succeeded)
				return string.Empty;

			var usuario = _signInManager.UserManager.Users
				.FirstOrDefault(user => user.NormalizedUserName == loginUsuarioDTO.Username);

			var token = _tokenService.GenerateToken(usuario);

			return token;
		}
	}
}
