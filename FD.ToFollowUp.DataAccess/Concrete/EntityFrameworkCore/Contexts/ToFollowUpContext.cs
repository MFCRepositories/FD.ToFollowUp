using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FD.ToFollowUp.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using FD.ToFollowUp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FD.ToFollowUp.DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class ToFollowUpContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ToFollowUpDb;integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KullaniciMap());
            modelBuilder.ApplyConfiguration(new CalismaMap());
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Calisma> Calismalar { get; set; }
    }
}
