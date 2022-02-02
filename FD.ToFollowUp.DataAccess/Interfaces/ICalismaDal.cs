using FD.ToFollowUp.Entities.Concrete;
using System.Collections.Generic;

namespace FD.ToFollowUp.DataAccess.Interfaces
{
    public interface ICalismaDal
    {
        void Kaydet(Calisma tablo);
        void Sil(Calisma tablo);
        void Guncelle(Calisma tablo);
        Calisma GetirIdile(int id);
        List<Calisma> GetirHepsi();

    }
}
