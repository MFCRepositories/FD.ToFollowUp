using FD.ToFollowUp.Entities.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FD.ToFollowUp.Entities.Concrete
{
    public class Calisma:ITablo
    {
        
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklamasi { get; set; }
        public DateTime OlusturulmaTarih { get; set; }
        public Kullanici Kullanici { get; set; }
        public int KullaniciId { get; set; }
      
    }
}
