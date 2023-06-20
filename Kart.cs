using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoUygulamasi
{
    public class Kart
    {
        private string Baslik;
        private string İçerik;
        private string Kisi;
        private string Buyukluk;
        private string Line;

  
        public string icerik { get => İçerik; set => İçerik = value; }
        public string Baslik1 { get => Baslik; set => Baslik = value; }
        public string Kisi1 { get => Kisi; set => Kisi = value; }
        public string Buyukluk1 { get => Buyukluk; set => Buyukluk = value; }
        public string Line1 { get => Line; set => Line = value; }

        public Kart(string İçerik1,string Baslik1,string Kisi1,string Buyukluk1,string Line1)
        {
            Baslik = Baslik1;
            İçerik = icerik;
            Kisi = Kisi1;
            Buyukluk= Buyukluk1;    
            Line=Line1;

        }
        public Kart() { }
    }
}
