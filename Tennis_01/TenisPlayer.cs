using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_01
{
    class TenisPlayer
    {
        private string playerName;
        private int score;
        private bool gameService;

        public TenisPlayer()
        {
            playerName = "";
        }

        public TenisPlayer(string name)
        {
            playerName = name;
        }
    }
}
