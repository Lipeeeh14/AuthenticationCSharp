using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationModule.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AcessoController : ControllerBase
	{
		[HttpGet]
		[Authorize(Policy = "IdadeMinima")]
		public IActionResult Get()
		{
			return Ok("Acesso permitido!");
		}
	}
}
