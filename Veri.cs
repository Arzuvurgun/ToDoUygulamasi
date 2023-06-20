using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoUygulamasi
{
    public class Veri : Kart
    {
        public static List<Kart> KartList=new List<Kart>();
        public static List<Kisi> KisiList=new List<Kisi>();

        static Veri()
        {
            KisiList = new List<Kisi>();
            new Kisi { id = 1, name = "Arzu" };
            new Kisi { id = 2, name = "Rana" };
            new Kisi { id = 3, name = "Emre" };
            new Kisi { id = 4, name = "Ali" };

            KartList = new List<Kart>();
            new Kart { Baslik1 = "Proje", icerik = "C# Projesi Yapılacak", Kisi1 = "Arzu", Buyukluk1= "M", Line1 = "TODO" };
            new Kart { Baslik1 = "Makale", icerik = "Asp .Net Core ile makale yazılacak.", Kisi1 = "Ali", Buyukluk1 = "S", Line1 = "DONE" };
            new Kart { Baslik1 = "Eğitim", icerik = "Js udemy kursları alınacak.", Kisi1 = "Rana", Buyukluk1 = "M", Line1 = "TODO" };
            new Kart { Baslik1 = "Toplantı", icerik = "42 İstanbul toplantısı yapılacak.", Kisi1 = "Emre", Buyukluk1 = "L", Line1 = "DONE" };
        }
        public static void Listele()
        {
            foreach (var item in KartList )
            {
                Console.WriteLine(item.Baslik1+" "+item.icerik+" "+item.Kisi1+" "+item.Buyukluk1+" "+item.Line1);

            }
        }
    }
}
