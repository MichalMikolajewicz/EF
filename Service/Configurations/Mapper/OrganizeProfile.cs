using AutoMapper;
using Data.Models;
using Models.BusinessModels;
using Service.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Configurations
{
	public class BusinessProfile : Profile
	{
		public BusinessProfile()
		{
			CreateMap<Person, PersonModel>();
		}
	}
}
