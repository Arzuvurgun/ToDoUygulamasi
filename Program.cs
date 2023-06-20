using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoUygulamasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
            Console.WriteLine("*****************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch(secim) 
            {
                case 1:
                    BoardListelemek.Listele();
                   break;
                case 2:
                    EklemeIslemi.Ekle();
                    break;
                case 3:
                    Silmeİslemi.Sil();
                    break;
                 case 4:
                    Tasimaİslemi.Taşı();
                    break;
             
            }
            Console.ReadLine(); 


        }
    }
}
