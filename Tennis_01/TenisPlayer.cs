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
        
        public TenisPlayer(string name)
        {
            PlayerName = name;
            Score = 0;
        }
        //------------------------------------
        public string PlayerName { get; private set; }
        public int Score { get; set; }
        public bool Service { get; set; }
        
    }
}
