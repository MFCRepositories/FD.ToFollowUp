using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FD.ToFollowUp.Entities.Concrete;
using FD.ToFollowUp.Entities.Interfaces;

namespace FD.ToFollowUp.DataAccess.Interfaces
{
    public interface IGenericDal<Tablo> where Tablo:class,ITablo,new()
    {
        void Kaydet(Tablo tablo);
        void Sil(Tablo tablo);
        void Guncelle(Tablo tablo);
        Tablo GetirIdile(int id);   
        List<Tablo> GetirHepsi(Tablo tablo);
    }
}
