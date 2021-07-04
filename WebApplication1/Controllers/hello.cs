using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    //
    // GET : /hello/
    public class Hello : Controller
    {
        public string Index()
        {
            return "hi its me";
        }
        public IActionResult Wel()
        {
            return View();
        }
    }
}
