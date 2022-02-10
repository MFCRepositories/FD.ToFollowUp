using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FD.ToFollowUp.WebUI.Models
{
    public class KullaniciKayitViewModel
    {

        [Required(ErrorMessage ="Adını gir laaa")]
        //Propertyler için <span asp-validation-for= Propertyname>
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
    }
}
