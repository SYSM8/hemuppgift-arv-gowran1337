

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        public int noPins;

        public Board(int noPins)
        {
            this.noPins = noPins;
        }



        public void SetUp(int noPins)
        {
            this.noPins = noPins;
        }

        public void TakePins(int pinsTaken)
        {
            noPins -= pinsTaken;
        }
        public void getNoPins(int noPins)
        {
            Console.WriteLine($"There are {noPins} pins left");
        }
        

    } 
}
