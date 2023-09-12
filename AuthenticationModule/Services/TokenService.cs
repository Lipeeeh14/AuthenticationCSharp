using AuthenticationModule.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthenticationModule.Services
{
	public class TokenService : ITokenService
	{
		public string GenerateToken(Usuario usuario)
		{
			Claim[] claims = new Claim[] 
			{
				new Claim("username", usuario.UserName),
				new Claim("id", usuario.Id),
				new Claim(ClaimTypes.DateOfBirth, usuario.DataNascimento.ToString()),
			};

			var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("5JHHajhdahs4aHFAOAIJFAS53LJSms"));

			var signingCredentials = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken 
			(
				expires: DateTime.Now.AddMinutes(10),
				claims: claims,
				signingCredentials: signingCredentials
			);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}
	}
}