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
    public class FormController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        //private readonly PolCalViewModel _context;
        public FormController(ILogger<HomeController> logger)
        {
            _logger = logger;   
        }

        [HttpPost]
public void FormOne(string textBoxStringData, int textBoxIntData, string checkboxData)
{
    //Do something
}


    }
    }