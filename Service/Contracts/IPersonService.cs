using Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface IPersonService
    {
		IEnumerable<PersonModel> GetPeople();

	}
}
