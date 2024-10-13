using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class ComputerPlayer:Player
    {
        public override string getUserID()
        {
            return "ROBOTPLAYER5000";
        }
        public override int TakePins()
        {
            Random random = new Random();
            int pinsTaken = random.Next(1, 3);
            return pinsTaken;
        }
    }
}
