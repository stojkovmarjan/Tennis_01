﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_01
{
    class TennisPlayer
    {
        public int PointsWon { get; set; }
        public string Name { get; set; }


        public TennisPlayer(string name)
        {
            PointsWon = 0;
            Name = name;
        }
       

        public override string ToString()
        {
            string scoreString = "";

            switch (PointsWon)
            {
                case 0: scoreString = "Love"; break;
                case 1: scoreString = "Fifteen"; break;
                case 2: scoreString = "Thirty"; break;
                default: scoreString = "Forty";break;
            }

            return scoreString;
        }

    }
}
