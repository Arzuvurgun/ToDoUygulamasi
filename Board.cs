﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoUygulamasi
{
    internal class Board
    {
       
        
            public List<Kart>? ToDo { get; set; }
            public List<Kart>? InProgress { get; set; }
            public List<Kart>? Done { get; set; }
        
    }
}
