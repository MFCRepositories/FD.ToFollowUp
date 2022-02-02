using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FD.ToFollowUp.Business.Interfaces;
using FD.ToFollowUp.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using FD.ToFollowUp.DataAccess.Concrete.EntityFrameworkCore.Repositorires;
using FD.ToFollowUp.Entities.Concrete;

namespace FD.ToFollowUp.Business.Concrete
{
    public class KullaniciManager:IKullaniciService
    {
        private readonly EfKullaniciRepository _efKullaniciRepository;

        public KullaniciManager(EfKullaniciRepository _efKullaniciRepository)
        {
              
        }

        public void Kaydet(Kullanici tablo)
        {
             
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

        public List<Kullanici> GetirHepsi(Kullanici tablo)
        {
            throw new NotImplementedException();
        }
    }
}
