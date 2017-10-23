using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            //how to display error 
            ViewBag.Errors = new List<string>();
            return View();
        }

        public IActionResult Welcome()
        {
            // ViewData["Message"] = "Hello " + name;
            // ViewData["NumTimes"] = numTimes;

            return View();
        }

        [HttpPost]
        [Route("process")]
        public IActionResult Process(string Name, string Location)
        {
            //add all errors in list
            ViewBag.Errors = new List<string>();
        // check name is added in page
            if(Name == null)
            {
                ViewBag.Errors.Add("Name cannot be empty");
            }

            // if erro arr has values in it
             if(ViewBag.Errors.Count > 0)
            {
                return View("Index");
            }

            //this is like session, save data from post 
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            return View("Welcome");
        }

    }

}