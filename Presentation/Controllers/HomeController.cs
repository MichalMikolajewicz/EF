using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data.Persistence;
using Data.Models;
using Data.Core;
using Service.Contracts;
using Models.BusinessModels;

namespace Presentation.Controllers
{

	public class HomeController : Controller
    {
		private readonly IPersonService personService;

		public HomeController(IPersonService personService)
		{
			this.personService = personService;
		}

		public IActionResult Index()
        {
			
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }

		[HttpGet("[action]")]
		public IEnumerable<PersonModel> ShowTable()
		{
			var people = personService.GetPeople().Take(10).ToList();
			return people;
		}

	}
}
