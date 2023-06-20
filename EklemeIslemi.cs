using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ToDoUygulamasi
{
    public class EklemeIslemi
    { 
        public static void Ekle() 
        {
            Kart yenikart= new Kart();
            Console.WriteLine("Başlık Giriniz:");
            string secim=Console.ReadLine();
            Console.WriteLine("İçerik giriniz:");
            string secim2=Console.ReadLine();
            Console.WriteLine("Büyüklük seçiniz XS(1), S(2), M(3), L(4), XL(5) ");
            int secim3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Atanacak kişiyi giriniz: ");
            int secim4 = Convert.ToInt32(Console.ReadLine());

            yenikart =new Kart();
            yenikart.Baslik1 = secim;
            yenikart.icerik = secim2;
            if(secim3 != null)
            {
                string buyuklukDeger=Enum.GetName(typeof(Kart), secim3);
                yenikart.Buyukluk1 = buyuklukDeger;

            }
            else
            {
                Console.WriteLine("Geçersiz bir karakter girdiniz.Lütfen tekrar deneyiniz.");
                Ekle();
            }
            var Kisi= Veri.KisiList.FirstOrDefault(x=>x.id==secim4);
            if(Kisi != null)
            {
                Veri.KartList.Add(yenikart);
            }
            else
            {
                Console.WriteLine("Geçersiz bir karakter girdiniz Lütfen tekrar deneyiniz.");
                Ekle();

            }


        }
    }
}
