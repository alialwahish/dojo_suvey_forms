using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcDojSurv.Models;

namespace MvcDojSurv.Controllers
{
    public class HomeController : Controller
    {
        Ninja ninja=new Ninja(){
            
        };
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(ninja);
        }
        [HttpPost]
        [Route("result")]
        public IActionResult Details(string name,string dojo_location, string favorite_language, string comment){
            ninja.Name=name;
            ninja.Location=dojo_location;
            ninja.Language=favorite_language;
            ninja.Comment=comment;
            return View(ninja);
        }





        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
