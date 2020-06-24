using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using evaluation1.Data;
using evaluation1.Models;

namespace evaluation1
{
    public class CitiesController : Controller
    {
        private readonly Eval1DbContext _context;

        public CitiesController(Eval1DbContext context)
        {
            _context = context;
        }

        // GET: Cities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.Cities
                .Include(c => c.Hotels)
                .FirstOrDefaultAsync(m => m.CityId == id);

            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }
    }
}
