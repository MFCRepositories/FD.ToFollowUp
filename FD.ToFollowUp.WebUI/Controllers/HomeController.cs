using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FD.ToFollowUp.WebUI.Models;
using Microsoft.CodeAnalysis.Diagnostics.Analyzers.NamingStyles;
using Microsoft.AspNetCore.Routing;

namespace FD.ToFollowUp.WebUI.Controllers
{
    //Route["Hayvan/[action]"]
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
        public IActionResult KayitOl()
        {

            return View();

        }
        [HttpPost]
        public IActionResult KayitOl2(KullaniciKayitViewModel model)
        {
            
            //if (ModelState.IsValid)
            //{
                
            //}
            ModelState.AddModelError("", "Modelde (model.Ad) alanı girişinden gelen hata");
            ModelState.AddModelError( nameof(KullaniciKayitViewModel.Ad), "hatası");
            ModelState.AddModelError( nameof(KullaniciKayitViewModel.Soyad), "hatası");
            return View("KayitOl",model);

        }

    }
}
