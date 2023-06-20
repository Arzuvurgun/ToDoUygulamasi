using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoUygulamasi
{
    public class Kartİcerigi
    {
        public static void KartGöster(string Line,List<Kart> lines)
        {
            Console.WriteLine(Line);
            Console.WriteLine("*********");


           foreach (var line in lines)
            {
                Console.WriteLine("Başlık:"+line.Baslik1);
                Console.WriteLine("İçerik:"+line.icerik);
                Console.WriteLine("Atanan Kişi:"+line.Kisi1);
                Console.WriteLine("Büyükük:"+line.Buyukluk1);
                Console.WriteLine("Line:"+line.Line1);
                Console.WriteLine("**************");
            }
           

        }
    }
}
