using AutoMapper;
using Business.Configurations.Contracts;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistance.Core.Domain;

namespace Business.Configurations.Implementations
{
	public static class BusinessMapper
	{
		public static void GetMapper()
		{
			Mapper.Initialize(cfg => {
				cfg.CreateMap<Person, PeopleModel>()
				.ForMember(dest => dest.LastName, m => m.MapFrom(src => src.FirstName + " " + src.MiddleName))
				.ForMember(dest => dest.Name, m => m.MapFrom(src => src.LastName))
				.ForMember(dest => dest.Description, m => m.MapFrom(src => src.Password.PasswordHash));

			});
		}

	}
}
