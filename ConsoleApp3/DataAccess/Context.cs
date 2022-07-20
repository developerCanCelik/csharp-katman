using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context : DbContext
    {

        /*
         --Contexti tablolarımın indexi olarak adlandırılabılırim
         Aynı zamanda bu yapıda using kullanıp entitydekı tablolarımı
         referans veriyorum Yani  ilişki kurmus da oluyorum.
         -- Bağlantımı da yine burada oluşturdum.

        --Bu Arada Migrationımın da sağlıklı çalışabilmesi için bazı nuget paketlerımı
          yuklemem gerekıyor
          (efcore.tools , .design ,baglantı yaptıgım ıcın efcore.sqlserver)

         */

        //MİGRATİON OLUŞTURMA

        /*
         İlk olarak package manager console ı acıyorum
         enable-migrations
         add-migration mig1
         update-database
         komnutlarımı verip yapımı oluşturuyorum 

        NOT !!!!!!   PROJEYI OLUŞTURURKEN SURUM FRAMEWORK NUGET ETC DIKKAT EDINIZ ...
        
         */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UDMLI44\SQLEXPRESS; Database=konsolDb; Trusted_Connection=true");

        }
        public DbSet<product> urunler { get; set; }
        public DbSet<categories> kategoriler { get; set; }



    }
}
