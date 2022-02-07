using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Diagnostics.Analyzers.NamingStyles;

namespace FD.ToFollowUp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            ViewBag.Isim = "Book";
            ViewData["Isim"] = "Human";
            TempData["gotur"] = "Su";
            return View();
            
        }
        public IActionResult Update()
        {

            var mesaj = (string)TempData["Isim"] ;
            
            return View();

        } 
        public IActionResult Sonuc()
        {

            var mesaj = (string)TempData["Isim"] ;
            
            return View();

        }

    }
}
