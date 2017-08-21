using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_01
{
    static class TennisMatch
    {
        /*possible play outcoms
        private const int ball_returned = 0;
        private const int ball_point = 1;
        private const int ball_out = 2;
        private const int ball_net = 3;
        private const int ball_let = 4;
        */

        private static TennisPlayer TennisPlayer1;
        private static TennisPlayer TennisPlayer2;
        //private static int Game;
        //private static int Set;
        //private static int PlayCounter;
        private static Random rnd = new Random();
     

        public static void Play()
        {
            TennisPlayer1 = new TennisPlayer("Player 1");
            TennisPlayer2 = new TennisPlayer("Player 2");
            //TennisPlayer1.Service = true;
            Console.WriteLine("\n\nPlayer 1 serve\nLOVE ALL");
            RandomPoint();
        }

        public static void Play(string player1name, string player2name)
        {
            TennisPlayer1 = new TennisPlayer(player1name);
            TennisPlayer2 = new TennisPlayer(player2name);
            Console.WriteLine("\n\nPlayer 1 serve\nLOVE ALL");
            RandomPoint();
        }

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

            Announce();
        }

        private static void Announce()
        {           

            if ((TennisPlayer1.PointsWon >= 4) && ((TennisPlayer1.PointsWon - TennisPlayer2.PointsWon) >= 2))
            {
                //Player 1 won the game
                Console.WriteLine("\nPlayer 1 won the game\n================================\n\n");
            }
            else if ((TennisPlayer2.PointsWon >= 4) && ((TennisPlayer2.PointsWon - TennisPlayer1.PointsWon) >= 2))
            {
                Console.WriteLine("\nPlayer 2 won the game\n================================\n\n");
            }
            else
            {
                Console.WriteLine("{0}:{1}", TennisPlayer1.PointsWon.ToString(),TennisPlayer2.PointsWon.ToString());
                Console.WriteLine(Score());
                Console.WriteLine("-------------------------------------------");
                RandomPoint();
            }


        }

        private static string Score()
        {
            string score = "";

            if ((TennisPlayer1.ToString().Equals(TennisPlayer2.ToString())) && (TennisPlayer2.PointsWon < 3))
            {
                score = TennisPlayer1.ToString() + " ALL";
            }
            // else if ((TennisPlayer1.ToString().Equals(TennisPlayer2.ToString())) && (TennisPlayer1.PointsWon >= 3))
            else if ((TennisPlayer1.PointsWon==TennisPlayer2.PointsWon) && (TennisPlayer1.PointsWon >= 3))
            {
                score = "DUCE";
            }
            else if ((TennisPlayer1.PointsWon - TennisPlayer2.PointsWon == 1) && (TennisPlayer1.PointsWon >= 4))
            {
                score = "Advantage In";
            }
            else if ((TennisPlayer2.PointsWon - TennisPlayer1.PointsWon == 1) && (TennisPlayer2.PointsWon >= 4))
            {
                score = "Advantage Out";
            }
            else
            {
                score = TennisPlayer1.ToString() + ":" + TennisPlayer2.ToString();
            }

            return score;
        }

        
    }

   

}
