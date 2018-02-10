using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimiyuMall.Controllers
{
    // our controller derives from a class in mvc called Controller
    public class AppController : Controller
    {
    // action returned by our controller
    public IActionResult Index()
        {
            // return a razor view
            return View();
        }
    
    }
}