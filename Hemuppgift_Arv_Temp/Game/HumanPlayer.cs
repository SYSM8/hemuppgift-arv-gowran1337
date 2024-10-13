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
        public HumanPlayer(string name)
        {
            this.Name = name;
        }
        public override string getUserID()
        {
            Console.WriteLine("Write your name");
            string Name = Console.ReadLine();
            return Name;
        }




        public override int TakePins()
        {
            while (true) //en loop så att metoden kan avslutas ifall använder skriver in annat än 1/2
            {
                Console.WriteLine("Take 1 or 2 pins?");
                int pinsTaken = Convert.ToInt32(Console.ReadLine());
                if (pinsTaken == 1 || pinsTaken == 2)
                {
                    Console.WriteLine($"{pinsTaken} was taken!");
                    return pinsTaken;
                }
                else
                {
                    Console.WriteLine("Choose 1 or 2");
                }
            }
        }
        }
    }

