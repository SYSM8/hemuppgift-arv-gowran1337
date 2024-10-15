using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class HumanPlayer:Player
    {
        public string Name { get; set; }
       
        
        public override string getUserID()
        {
            Console.WriteLine("Write your name");
            Name = Console.ReadLine();
            Console.Clear();
            return Name;
        }


        public override int noTakePins()
        {

            while (true) //en loop så att metoden kan avslutas ifall använder skriver in annat än 1/2
            {
                try
                {
                    Console.WriteLine($"Will {Name} take 1 or 2 pins?");
                    pinsTaken = Convert.ToInt32(Console.ReadLine());
                    if (pinsTaken == 1 || pinsTaken == 2)
                    {
                        Console.WriteLine($"{Name} takes {pinsTaken} pins!");
                        return pinsTaken;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! you may only take 1 or 2 pins");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Fel format");
                }
           }
       }        
   }
 
}

