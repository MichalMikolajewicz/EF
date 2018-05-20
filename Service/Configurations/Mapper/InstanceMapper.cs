using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Configurations
{
    public class InstanceMapper
    {
		private IConfigurationProvider configurationProvider;
		public InstanceMapper(IConfigurationProvider configurationProvider)
		{
			this.configurationProvider = configurationProvider;
		}

		public IMapper GetMapper()
		{
			return configurationProvider.CreateMapper();
		}
	}
}
