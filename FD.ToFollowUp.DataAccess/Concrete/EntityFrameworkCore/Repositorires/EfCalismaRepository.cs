using FD.ToFollowUp.DataAccess.Interfaces;
using FD.ToFollowUp.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace FD.ToFollowUp.DataAccess.Concrete.EntityFrameworkCore.Repositorires
{
    public class EfCalismaRepository:ICalismaDal
    {
        public void Kaydet(Calisma tablo)
        {
            throw new NotImplementedException();
        }

        public void Sil(Calisma tablo)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Calisma tablo)
        {
            throw new NotImplementedException();
        }

        public Calisma GetirIdile(int id)
        {
            throw new NotImplementedException();
        }

        public List<Calisma> GetirHepsi()
        {
            throw new NotImplementedException();
        }
    }
}
