using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FD.ToFollowUp.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using FD.ToFollowUp.DataAccess.Interfaces;
using FD.ToFollowUp.Entities.Concrete;
using FD.ToFollowUp.Entities.Interfaces;

namespace FD.ToFollowUp.DataAccess.Concrete.EntityFrameworkCore.Repositorires
{
    public class EfGenericRepository<Tablo>:IGenericDal<Tablo> where Tablo:class,ITablo,new()
    {
        public void Kaydet(Tablo tablo)
        {
            using var context = new ToFollowUpContext();
            //context.Set<Calisma>()=context.Calismalar
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();
        }

        public void Sil(Tablo tablo)
        {
            using var context = new ToFollowUpContext();
            //context.Set<Calisma>()=context.Calismalar
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }

        public void Guncelle(Tablo tablo)
        {
            using var context = new ToFollowUpContext();
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();
        }

        public Tablo GetirIdile(int id)
        {    //context.Set<Calisma>()=context.Calismalar
            using var context = new ToFollowUpContext();
            return context.Set<Tablo>().Find(id);
           
        }

        public List<Tablo> GetirHepsi(Tablo tablo)
        {   //context.Set<Calisma>()=context.Calismalar
            using var context = new ToFollowUpContext();
            return context.Set<Tablo>().ToList();
        }
    }
}
