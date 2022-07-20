using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
       
        /*
         Tablolarım için teker teker 
         crud işlemleri yapmak hem kod fazlalığı ve güvenlik açığı 
         oluşturup hata oranını yukseltecegı ıcın 

         Rep.Des.Pat. Yaklasımını kullanıyorum Buna göre Veri T. İşlemleri
         Bir noktadan yönetiliyor
         
         Oluşturduğum interfacemın içerisinde crud metodlarımı tanımlıyorum
         Sonrasında bu metodlara görevlendirmeyi classa implement ederek yapacagım 
         ve businessde yani butun işlerimin filtrelerimin etc döndüğü katmana oradaki
         başka bir classla bağlayacağım.
        
         */


        int Insert(T p);
        int Update(T p);
        int Delete(T p);

        List<T> List();

        T GetById(int id);


    }
}
