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
    // action returned by our controller for Index
    public IActionResult Index()
        {
            // return a razor view
            return View();
        }
    
    // action result for our contact page
    public IActionResult Contact()
        {
            // setting our contact page title in the controler action class
            ViewBag.Title = "Contact Us";

            return View();

        }

        // action result for our about page
        public IActionResult About()
        {
            // setting our contact page title in the controler action class
            ViewBag.Title = "About Us";

            return View();

        }


    }
}