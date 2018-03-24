using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimiyuMall.Services;
using SimiyuMall.ViewModels;

namespace SimiyuMall.Controllers
{
    // our controller derives from a class in mvc called Controller
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        // inject our services in the app controller
        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }
    // action returned by our controller for Index
    public IActionResult Index()
        {
            // return a razor view
            return View();
        }
    
    // action result for our contact page
    [HttpGet("contact")]
    public IActionResult Contact()
        {
            // setting our contact page title in the controler action class
            ViewBag.Title = "Contact Us";

            /* exceptional handling for our production code */
            //throw new InvalidOperationException("Bad things happen");

            return View();

        }
    [HttpPost("contact")]
    public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // send the email message
                _mailService.SendMessage("kensimiyu2015@gmail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();

            }
            else
            {
                // show the errors
            }
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