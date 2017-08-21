using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_01
{
    class TennisPlayer
    {
        public TennisPlayer(string name)
        {
            PlayerName = name;
            PointsWon = 0;
            GamesWon = 0;
            SetsWon = 0;
        }
        
        public string PlayerName { get; set; }
        public int PointsWon { get; set; }
        public int GamesWon { get; set; }
        public int SetsWon { get; set; }
        public bool Service { get; set; }

        public override string ToString()
        {
            string scoreString = "40";

            switch (PointsWon)
            {
                case 0: scoreString = "Love"; break;
                case 1: scoreString = "15"; break;
                case 2: scoreString = "30"; break;
                default: scoreString = "40";break;
            }

            return scoreString;
        }

    }
}
