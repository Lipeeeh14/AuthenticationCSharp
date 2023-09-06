using AuthenticationModule.Data.DTOs;
using AuthenticationModule.Models;
using AutoMapper;

namespace AuthenticationModule.Profiles
{
	public class UsuarioProfile : Profile
	{
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDTO, Usuario>();
        }
    }
}
