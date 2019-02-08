using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class DanceController : Controller
    {
        public IActionResult ShowText()
        {
            return Content("Here is the dance page. ");
        }
        public IActionResult ShowJSON()
        {
            return Json(new { name = "favorite dance form", style = "This is my favorite dance form." });
        }
        public IActionResult ShowHTML()
        {
            var h = "<!DOCTYPE html><html><body>Indian classical dance, or Shastriya Nritya, is an umbrella term for various performance arts rooted in religious Hindu musical theatre styles</body></html>";
            return Content(h, "text/html");
        }

        public IActionResult ShowView()
        {
            return View();
        }
    }
}
