using FD.ToFollowUp.DataAccess.Interfaces;
using FD.ToFollowUp.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace FD.ToFollowUp.DataAccess.Concrete.EntityFrameworkCore.Repositorires
{
    public class EfKullaniciRepository:EfGenericRepository<Kullanici>,IKullaniciDal
    {
       
    }
}
