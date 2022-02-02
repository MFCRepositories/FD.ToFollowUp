using FD.ToFollowUp.DataAccess.Interfaces;
using FD.ToFollowUp.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace FD.ToFollowUp.DataAccess.Concrete.EntityFrameworkCore.Repositorires
{
    public class EfKullaniciRepository:IKullaniciDal
    {
        public void Kaydet(Kullanici tablo)
        {
            throw new NotImplementedException();
        }

        public void Sil(Kullanici tablo)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Kullanici tablo)
        {
            throw new NotImplementedException();
        }

        public Kullanici GetirIdile(int id)
        {
            throw new NotImplementedException();
        }

        public List<Kullanici> GetirHepsi()
        {
            throw new NotImplementedException();
        }
    }
}
