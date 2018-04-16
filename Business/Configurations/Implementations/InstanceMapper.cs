using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configurations.Implementations
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
