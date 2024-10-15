using System.Security.Cryptography.X509Certificates;

namespace Hemuppgift_Arv_Temp.Game
{
    public class TakePinsGame
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            Board spel = new ();
            HumanPlayer player1 = new ();
            ComputerPlayer CP1 = new();

            spel.SetUp();
            player1.getUserID();
            CP1.getUserID();

            

            while (spel.noPins > 0)
            {               
                player1.noTakePins();              
                spel.TakePins(player1.pinsTaken);
                Console.WriteLine("------------------");
                if( spel.noPins == 0)
                {
                    Console.Clear();
                    Console.WriteLine(player1.Name + " wins!");
                    break;
                }
                spel.getNoPins();

                CP1.noTakePins();
                spel.TakePins(CP1.pinsTaken);
                Console.WriteLine("------------------");
                if (spel.noPins == 0)
                {
                    Console.Clear();
                    Console.WriteLine("ROBOTPLAYER500 wins!");
                    break;
                }
                spel.getNoPins();
            }


           




        }

    }
}
