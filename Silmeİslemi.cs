using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ToDoUygulamasi
{
    public class Silmeİslemi:Veri
    {
        public static void Sil()
        {
            Console.WriteLine("Öncelikle silmek idtediğiniz kartı seçiniz:");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string baslık=Console.ReadLine();
            foreach (var kart in KartList.ToList())
            {
                if (kart.Baslik1== baslık)
                {
                    KartList.Remove(kart);
                }
                else
                {
                    Console.WriteLine("Aradığınız kritere uygun bir kart board'da bulunamadı.Lütfen bir seçim yapınız:");
                    Console.WriteLine("Silmeyi sonlandırmak için:(1)");
                    Console.WriteLine("Yeniden denemek için (2)");
                    int secim=Convert.ToInt32(Console.ReadLine()); 
                    
                    if(secim==1)
                    {
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    }
                    else
                    {
                        Sil();
                    }
                }
            }
        }

    }
}
