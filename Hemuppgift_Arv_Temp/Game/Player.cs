﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
     public abstract class Player
    { 
        public int pinsTaken {  get; set; }

        public abstract string getUserID();
        public abstract int noTakePins();
    }
}
