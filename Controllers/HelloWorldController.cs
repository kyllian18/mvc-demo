using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvc_demo.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int numTimes = 1)
        {
            ViewData["College"] = "Dorset";
            ViewData["ComicUniverse"] = "DC Comics";
            ViewData["Heroes"] = new string[] { "Batman", "Superman", "The Hulk" };
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        //public string Index()
        //{
        //    return "This is my default action.";
        //}

        //public string Welcome(int id, string name = "World", int counter = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"The id is {id}. Hello {name}! Counter is {counter}.");
        //}
    }
}
