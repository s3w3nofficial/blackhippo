using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using blackhippo.Models;

namespace blackhippo.Controllers
{
    public class EshopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product(int id) 
        {
            ViewBag.id = id;
            return View();
        } 

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
