using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data.Persistence;
using Data.Models;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
		private readonly AdventureWorks2014Context _context;

		public HomeController(AdventureWorks2014Context context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
			var people = _context.Person.Where(x => x.BusinessEntityId > 10).Take(2).ToList(); // good!
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
