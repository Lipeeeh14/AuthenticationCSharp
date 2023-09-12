using AuthenticationModule.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationModule.Data
{
	public class UsuarioContext : IdentityDbContext<Usuario>
	{
		public UsuarioContext(DbContextOptions options) 
			: base(options)
		{
		}
	}
}
