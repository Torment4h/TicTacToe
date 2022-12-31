using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Winner
    {
        private int[] win1 = new int[3]; 
        private int[] win2 = new int[3]; 
        private int[] win3 = new int[3]; 
        private int[] win4 = new int[3]; 
        private int[] win5 = new int[3]; 
        private int[] win6 = new int[3]; 
        private int[] win7 = new int[3]; 
        private int[] win8 = new int[3];
        
    public bool winchecker(Player playern)
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (playern.GetValue(i) == win1[j]) i++;
                }
            }
            return true;
        }
    }
}
