using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PolCal.Models;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using PolCal.Data;
using Microsoft.AspNetCore.Http; 

namespace PolCal.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        //private readonly PolCalViewModel _context;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("Test", "Bulo");
            return View();
        }

        public IActionResult PolCalApp()
        {
            ViewBag.Message = HttpContext.Session.GetString("Test");
            @ViewBag.Name = "Bulent";
            return View();
        }

          public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
  public IActionResult formPolicy()
        {
            return View();
        }

        [HttpGet]//burası post olacak ve burada submit denilince bilgiler gelecek.
        public int amountCal(){


            return 1;

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
