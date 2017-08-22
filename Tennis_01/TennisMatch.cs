﻿using System;
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
            Console.WriteLine("\n\nPlayer 1 serve\nLOVE ALL\n================================");
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

            Announce();
        }

        private static void Announce()
        {           

            if ((TennisPlayer1.PointsWon >= 4) && ((TennisPlayer1.PointsWon - TennisPlayer2.PointsWon) >= 2))
            {
                //Player 1 won the game
                Console.WriteLine("\nWin for Player 1\n================================\n\n");
            }
            else if ((TennisPlayer2.PointsWon >= 4) && ((TennisPlayer2.PointsWon - TennisPlayer1.PointsWon) >= 2))
            {
                //Player 2 won the game
                Console.WriteLine("\nWin for Player 2\n================================\n\n");
            }
            else
            {
               // Console.WriteLine("{0}:{1}", TennisPlayer1.PointsWon.ToString(),TennisPlayer2.PointsWon.ToString());
                Console.WriteLine(Score());
                Console.WriteLine("-------------------------------------------");
                RandomPoint();
            }


        }

        private static string Score()
        {
            string score = "";

            if ((TennisPlayer1.PointsWon == TennisPlayer2.PointsWon) && (TennisPlayer2.PointsWon < 3))
            {
                score = TennisPlayer1.ToString() + "-All";
            }
            // else if ((TennisPlayer1.ToString().Equals(TennisPlayer2.ToString())) && (TennisPlayer1.PointsWon >= 3))
            else if ((TennisPlayer1.PointsWon==TennisPlayer2.PointsWon) && (TennisPlayer1.PointsWon >= 3))
            {
                score = "Deuce";
            }
            else if ((TennisPlayer1.PointsWon - TennisPlayer2.PointsWon == 1) && (TennisPlayer1.PointsWon >= 4))
            {
                score = "Advantage Player 1";
            }
            else if ((TennisPlayer2.PointsWon - TennisPlayer1.PointsWon == 1) && (TennisPlayer2.PointsWon >= 4))
            {
                score = "Advantage Player 2";
            }
            else
            {
                score = TennisPlayer1.ToString() + "-" + TennisPlayer2.ToString();
            }

            return score;
        }  
    }

   

}
