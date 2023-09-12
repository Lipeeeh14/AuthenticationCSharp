using Microsoft.AspNetCore.Identity;

namespace AuthenticationModule.Models
{
	public class Usuario : IdentityUser
	{
        public DateTime DataNascimento { get; private set; }

        public Usuario() : base() { }
    }
}
