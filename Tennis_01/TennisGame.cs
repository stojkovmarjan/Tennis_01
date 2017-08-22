using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_01
{
    static class TennisGame
    {
        private static TennisPlayer TennisPlayer1;
        private static TennisPlayer TennisPlayer2;
        private static Random rnd = new Random();
     
        
        public static void Play()
        {
            TennisPlayer1 = new TennisPlayer("Player 1");
            TennisPlayer2 = new TennisPlayer("Player 2");
            Console.WriteLine("\n\nPlayer 1 service\n\t\tLOVE ALL\n================================");
            RandomPoint();
        }
        //public static TennisPlayer TennisPlayer1 { get; set; }
        private static void RandomPoint()
        {
            int randomPoint = rnd.Next(100);

            if (randomPoint<50) {
                Console.WriteLine("player 1 scores");
                TennisPlayer1.PointsWon++;
            } else
            {
                Console.WriteLine("player 2 scores");
                TennisPlayer2.PointsWon++;
            }

            CallScore();
        }

        private static void CallScore()
        {           

            if ((TennisPlayer1.PointsWon >= 4) && ((TennisPlayer1.PointsWon - TennisPlayer2.PointsWon) >= 2))
            {
                //Player 1 won the game
                Console.WriteLine("\n\t\tWin for Player 1\n================================\n\n");
            }
            else if ((TennisPlayer2.PointsWon >= 4) && ((TennisPlayer2.PointsWon - TennisPlayer1.PointsWon) >= 2))
            {
                //Player 2 won the game
                Console.WriteLine("\n\t\tWin for Player 2\n================================\n\n");
            }
            else
            {
               // Console.WriteLine("{0}:{1}", TennisPlayer1.PointsWon.ToString(),TennisPlayer2.PointsWon.ToString());
                Console.WriteLine("\t\t{0}",Score(TennisPlayer1,TennisPlayer2));
                Console.WriteLine("-------------------------------------------");
                RandomPoint();
            }


        }

        private static string Score(TennisPlayer server, TennisPlayer receiver)
        {
            string score = "";

            if ((server.PointsWon == receiver.PointsWon) && (server.PointsWon < 3))
            {
                score = server.ToString() + "-All";
            }
            // else if ((TennisPlayer1.ToString().Equals(TennisPlayer2.ToString())) && (TennisPlayer1.PointsWon >= 3))
            else if ((server.PointsWon== receiver.PointsWon) && (server.PointsWon >= 3))
            {
                score = "Deuce";
            }
            else if ((server.PointsWon - receiver.PointsWon == 1) && (server.PointsWon >= 4))
            {
                score = "Advantage "+server.Name;
            }
            else if ((receiver.PointsWon - server.PointsWon == 1) && (receiver.PointsWon >= 4))
            {
                score = "Advantage "+receiver.Name;
            }
            else
            {
                score = TennisPlayer1.ToString() + "-" + TennisPlayer2.ToString();
            }

            return score;
        }  
    }

   

}
