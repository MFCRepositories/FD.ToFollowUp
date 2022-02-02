using FD.ToFollowUp.Entities.Concrete;
using System.Collections.Generic;

namespace FD.ToFollowUp.DataAccess.Interfaces
{
    public interface IKullaniciDal
    {
        void Kaydet(Kullanici tablo);
        void Sil(Kullanici tablo);
        void Guncelle(Kullanici tablo);
        Kullanici GetirIdile(int id);
        List<Kullanici> GetirHepsi();
    }
}
