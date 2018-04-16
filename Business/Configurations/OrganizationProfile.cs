using AutoMapper;
using Business.Models;
using Persistance.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configurations
{
	public class BusinessProfile : Profile
	{
		public BusinessProfile()
		{
			CreateMap<Person, PeopleModel>()
				.ForMember(dest => dest.LastName, m => m.MapFrom(src => src.FirstName + " " + src.MiddleName))
				.ForMember(dest => dest.Name, m => m.MapFrom(src => src.LastName))
				.ForMember(dest => dest.Description, m => m.MapFrom(src => src.Password.PasswordHash));
		}
	}
}
