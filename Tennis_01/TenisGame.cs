using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_01
{
    class TenisGame
    {
        private TenisPlayer tenisPlayer1;
        private TenisPlayer tenisPlayer2;

        // constructors
        public TenisGame()
        {
            tenisPlayer1 = new TenisPlayer("Player1");
            tenisPlayer2 = new TenisPlayer("Player2");
        }
        public TenisGame(TenisPlayer player1,TenisPlayer player2)
        {
            tenisPlayer1 = player1;
            tenisPlayer2 = player2;
        }
        public TenisGame(string player1Name, string player2Name)
        {
            tenisPlayer1 = new TenisPlayer(player1Name);
            tenisPlayer2 = new TenisPlayer(player2Name);
        }
        //----------------------------------------------------------
    }
}
