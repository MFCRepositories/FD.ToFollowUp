using FD.ToFollowUp.DataAccess.Interfaces;
using FD.ToFollowUp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using FD.ToFollowUp.DataAccess.Concrete.EntityFrameworkCore.Contexts;

namespace FD.ToFollowUp.DataAccess.Concrete.EntityFrameworkCore.Repositorires
{
    public class EfCalismaRepository:EfGenericRepository<Calisma>,ICalismaDal
    {
        
    }
}
