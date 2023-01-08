using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Positions
    {
        private int position;

        public void SetPosition(BoardMatrix board, Options option)
        {
            Console.Write("Enter the position: ");
            string temp = Console.ReadLine();
            position = Convert.ToInt32(temp);
            if ( option == Options.X) board.SetValue(position, option);
            else if (option == Options.O) board.SetValue(position, option);
            else if (option == Options.X) board.SetValue(position, option);
        }
    }
}
