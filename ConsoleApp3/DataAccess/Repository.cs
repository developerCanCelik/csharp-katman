using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {   
        /*
         IRepository interfaceımde tanımladıgım crud methodlarımı
         burda implement ederek görevlendirmelerini yapıyorum
         Ancak interfaceı baglamam yeterlı degıl cunku calısılacak tablolarımda mevcut
         Bunun için Context sınıfımı ve Dbset ten tureyen nesnemı olusturuyorum
         
         */


        Context c = new Context();
        DbSet<T> _object;

        public Repository()
        {

            _object = c.Set<T>();


        }
        public int Delete(T p)
        {
             _object.Remove(p);
            return c.SaveChanges();

        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T p)
        {
            _object.Add(p);
            return c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public int Update(T p)
        {
            return c.SaveChanges();
        }
    }
}
