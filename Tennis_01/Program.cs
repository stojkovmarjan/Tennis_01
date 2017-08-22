using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string again = "y";
            
            while (again.Equals("y"))
            {
                TennisGame.Play();

                Console.Write("Again (y/n)? ");
                again = Console.ReadLine();
                again = again.ToLower();
            }
           
        }
    }
}
