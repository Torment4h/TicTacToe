using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Player
    {
        private int[] player = new int[5];

        //Constructor set everythign to U (Undefined) :>
        public Player() {
            for (int i = 0; i < 5; i++) player[i] = 0;
        }

        public void SetValue(int value)
        {
            int i=0;
            player[i] = value;
            i++;
        }

        public int GetValue(int position)
        {
            return player[position];
        }






    }
}
