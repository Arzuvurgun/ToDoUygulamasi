using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoUygulamasi
{
    public class Tasimaİslemi : Veri
    {
        public static void Taşı()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();

            foreach (var item in KartList)
            {
                if (item.Baslik1 == input)
                {
                    Console.WriteLine("Bulunan Kart Bigileri");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Başlık     : " + item.Baslik1);
                    Console.WriteLine("İçerik     : " + item.icerik);
                    Console.WriteLine("Atanan Kişi: " + item.Kisi1);
                    Console.WriteLine("Büyüklük   : " + item.Buyukluk1);
                    Console.WriteLine("Line       : " + item.Line1);
                    Console.WriteLine();
                    Console.WriteLine("Lütfen taşıman istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) INPROGRESS");
                    Console.WriteLine("(3) DONE");

                    int input1 = Convert.ToInt32(Console.ReadLine());

                    switch (input1)
                    {
                        case 1:
                            item.Line1 = "TODO";
                            break;
                        case 2:
                            item.Line1 = "INPROGRESS";
                            break;
                        case 3:
                            item.Line1 = "DONE";
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Hatalı bir tuşlama yaptınız.");
                    break;
                }
            }
        }
    }
}
