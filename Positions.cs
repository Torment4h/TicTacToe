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

        public void SetPosition()
        {
            Console.Write("Enter the position: ");
            string temp = Console.ReadLine();
            position = Convert.ToInt32(temp);

        }

    }
}
