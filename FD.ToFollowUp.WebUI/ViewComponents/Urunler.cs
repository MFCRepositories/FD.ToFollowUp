using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FD.ToFollowUp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FD.ToFollowUp.WebUI.ViewComponents
{
    public class Urunler:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Yeni",new List<MusteriViewModel>
            {
                new MusteriViewModel{Ad = "Ahmet"},
                new MusteriViewModel{Ad = "Mehmet"}

            });

        }
        
    }
}
