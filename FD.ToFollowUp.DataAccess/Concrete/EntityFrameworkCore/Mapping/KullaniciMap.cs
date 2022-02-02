using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FD.ToFollowUp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FD.ToFollowUp.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class KullaniciMap:IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            //int seed = 501;
            builder.HasKey(I => I.Id);
            builder.Property(I=>I.Id).UseIdentityColumn();
            builder.Property(I=>I.Ad).HasMaxLength(100).IsRequired();
            builder.Property(I=>I.Soyad).HasMaxLength(100).IsRequired(false);
            //builder.HasCheckConstraint("Yas", "[Yas]>18 and [Yas]<99");
            builder.Property(I => I.Telefon).HasMaxLength(50);
            //builder.Property(I=>I.Telefon).HasMaxLength(50).IsRequired().HasDefaultValueSql("('Tel Yok')");
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();

            builder.HasMany(x => x.Calismalar)
                .WithOne(x => x.Kullanici)
                .HasForeignKey(x => x.KullaniciId);

            //builder.HasData(new Kullanici
            //{
            //    Id = 500,
            //    Ad = "Belirsiz",
            //    Soyad = "Belirsiz",
                
            //    Email = "Belirsiz",
            //    Telefon = "Belirsiz",
            //});

            //for (int i = 0; i < 5; i++)
            //{
            //    builder.HasData(new Kullanici
            //    {
            //        Id = seed + i,
            //        Ad = FakeData.NameData.GetFirstName(),
            //        Soyad = FakeData.NameData.GetSurname(),
            //        Yas = FakeData.NumberData.GetNumber(19, 99),
            //        Email = AppDomain+Soyad@gmail.com,
            //        Telefon = FakeData.PhoneNumberData.GetPhoneNumber(),
            //    });
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Kullanici a = new Kullanici
            //    {
            //        Id = seed + i,
            //        Ad = FakeData.NameData.GetFirstName(),
            //        Soyad = FakeData.NameData.GetSurname(),
                  
            //    };
            //    //a.Email = a.Ad + a.Soyad + "@gmail.com";
            //    a.Email = FakeData.NetworkData.GetEmail();
         
            //    builder.HasData(a);
            //}
            
           


        }
    }
}
