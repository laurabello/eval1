using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using evaluation1.Models;
using Microsoft.AspNetCore.Identity;
using evaluation1.Data;

namespace evaluation1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Eval1DbContext _context;


        public HomeController(ILogger<HomeController> logger, Eval1DbContext eval1DbContext)
        {
            _logger = logger;
            _context = eval1DbContext;
        }

        public IActionResult Index()
        {
            List<City> cities = _context.Cities.ToList();
            return View(cities);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
