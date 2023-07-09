using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_APP.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View(new calc());
        }


        [HttpPost]
        public ActionResult Index(calc c, string calculate)

        {
            if(calculate == "add")

        }
    }
}