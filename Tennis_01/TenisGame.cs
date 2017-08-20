using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_01
{
    class TenisGame
    {
        //possible play outcoms
        private const int ball_returned = 0;
        private const int ball_point = 1;
        private const int ball_out = 2;
        private const int ball_net = 3;
        private const int ball_let = 4;
        //----------------------------------

        private TenisPlayer TenisPlayer1;
        private TenisPlayer TenisPlayer2;
        //private int Game;
        private int Set;
        private int PlayCounter;
        private Random rnd = new Random();
     

        public void StartGame()
        {
            //game starts with player 1 service
            PlayCounter = 0;
        }

        /*
        int GetPlayOutcome()
        {
            //int outcom = 0;

            int randomOutcom = rnd.Next(100);

            switch (randomOutcom)
            {
                case (0): outcom = 0; break;
            }

            return 0;// outcome;
        }
        */

    }

   

}
