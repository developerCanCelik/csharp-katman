
using Business;

namespace ConsoleApp3
{
    class Program
    {
           /*
             !!!!!!!!!!

            Program.cs -> CategoryMan -> Repository -> IRepository

           Artık işin son kısmına yanı UI kanadına geldik
           İş katmanında oluşturdugum yapıları buraya taşıyorum
           Bunu yapmak için Categoryman sınıfından bır nesne turetıp
           For dongusuyle elemanlarımı tek tek cekıyorum ...
           
            */
            

           static void Main(String[]args)
        {
            CategoryMan km = new CategoryMan();

            foreach (var item in km.GetAll())
            {

                Console.WriteLine("ID:"+" "+item.categoryid+" "+"KATEGORİ İSMİ:"+" "+item.categoryname);

            }


        }


    }






}