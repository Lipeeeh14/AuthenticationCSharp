using AuthenticationModule.Data.DTOs;
using AuthenticationModule.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationModule.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsuarioController : ControllerBase
	{
		private readonly IUsuarioService _usuarioService;

		public UsuarioController(IUsuarioService usuarioService)
		{
			_usuarioService = usuarioService;
		}

		[HttpPost]
		public async Task<IActionResult> CadastraUsuario(CreateUsuarioDTO createUsuarioDTO)
		{
			var result = await _usuarioService.CadastrarUsuario(createUsuarioDTO);

			if (!result)
				return BadRequest("Erro ao cadastrar o usuário!");

			return Ok("Usuário cadastrado com sucesso!");
		}

		[HttpPost]
		[Route("login")]
		public async Task<IActionResult> Login(LoginUsuarioDTO loginUsuarioDTO)
		{
			var result = await _usuarioService.Login(loginUsuarioDTO);

			if (string.IsNullOrEmpty(result))
				return BadRequest("Erro ao realizar o login!");

			return Ok(result);
		}
	}
}
