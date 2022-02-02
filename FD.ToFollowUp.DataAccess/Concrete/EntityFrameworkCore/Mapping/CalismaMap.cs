using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FD.ToFollowUp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FD.ToFollowUp.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class CalismaMap:IEntityTypeConfiguration<Calisma>
    {
        public void Configure(EntityTypeBuilder<Calisma> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(I => I.Ad).HasMaxLength(200);
            builder.Property(I => I.Aciklamasi).HasColumnName("ntext");



            //builder.Property(c => c.KullaniciId).HasDefaultValueSql("((0))");
            //for (int i = 1; i < 12; i++)
            //{
            //    Calisma c = new Calisma
            //    {

            //        Id = i,
            //        Aciklamasi = FakeData.TextData.GetSentences(3),
            //        Ad = FakeData.TextData.GetSentence(),
            //        OlusturulmaTarih = DateTime.Now,
            //    };
            //    builder.HasData(c);
            //}


        }
    }
}
