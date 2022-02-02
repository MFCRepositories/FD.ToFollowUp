using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FD.ToFollowUp.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FD.ToFollowUp.Business.Interfaces
{
    public interface IGenericService<Tablo> where Tablo:class,ITablo,new()
    { void Kaydet(Tablo tablo);
        void Sil(Tablo tablo);
        void Guncelle(Tablo tablo);
        Tablo GetirIdile(int id);
        List<Tablo> GetirHepsi(Tablo tablo);

    }
}
