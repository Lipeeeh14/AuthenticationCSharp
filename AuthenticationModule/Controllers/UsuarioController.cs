using AuthenticationModule.Data.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationModule.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsuarioController : ControllerBase
	{
		[HttpPost]
		public IActionResult CadastraUsuario(CreateUsuarioDTO createUsuarioDTO) 
		{
			throw new NotImplementedException();
		}
	}
}
