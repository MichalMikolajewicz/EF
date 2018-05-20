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
			var people = personService.GetPeople(); // good!
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
