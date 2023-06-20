using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ToDoUygulamasi
{
    public class BoardListelemek
    {
        private static Board boards;
        public static void LineBoard()
        { 
            var todo=Veri.KartList.Where(x=>x.Line1=="TODO").ToList();
            var ınprogress = Veri.KartList.Where(x => x.Line1 == "İNPROGRESS").ToList();
            var done =Veri.KartList.Where(x=> x.Line1 =="DONE").ToList();

            boards = new Board();
            boards.ToDo = todo;
            boards.InProgress = ınprogress;
            boards.Done=done;


        }
        public static void Listele()
        {
            LineBoard();
            Kartİcerigi.KartGöster("TODO Line", boards.ToDo);
            Kartİcerigi.KartGöster("İNPROGRESS",boards.InProgress);
            Kartİcerigi.KartGöster("DONE", boards.Done);
        }
       

    }
        
    
}
