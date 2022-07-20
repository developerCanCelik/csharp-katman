using DataAccess;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class CategoryMan
    {

        /*
        -- Görevlendirme yaptığım repository classımdan(interfaceı ımp.ettgm) 
         Bir nesne türettim Tabi bunuda categories tablomla bağladım.
        -- Sonrada Listeleme Yapmak için Kullanacağım bir metod oluşturdum
         Bu metodun içersinde de repository classımdakı list metodunu çekip
         kullanıp listeleme yaptım
         
         */



        Repository<categories> categoryrepo = new Repository<categories>();

        public List<categories> GetAll()
        {

            return categoryrepo.List();
        }




    }
}
