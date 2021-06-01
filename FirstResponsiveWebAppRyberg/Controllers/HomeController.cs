using FirstResponsiveWebAppRyberg.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResponsiveWebAppRyberg.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = 0;
            ViewBag.Name = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(AgeCalculator model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = model.AgeThisYear();
                ViewBag.Name = model.Name;
            } 
                else
            {
                ViewBag.Age = 0;
            }

            return View(model);
        }
    }
}
