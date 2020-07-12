using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AsliPehlivan_Project.Models;
using AsliPehlivan_Project.Data;
using AsliPehlivan_Project.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace AsliPehlivan_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
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

        public async Task<IActionResult> Search()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Search(SearchModel searchModel)
        {
            var orders = _context.Orders.AsQueryable();
            if (!String.IsNullOrWhiteSpace(searchModel.SearchText))
            {
                orders = orders.Where(o => o.City.Contains(searchModel.SearchText));
                searchModel.Results = await orders.ToListAsync();
            }
            else
            {
                searchModel.Results = await orders.ToListAsync();
            }


            return View(searchModel);
        }
    }
}
