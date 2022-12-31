using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        public int i;
        static void Main(string[] args)
        {
            Program program = new Program();    
            BoardMatrix board1 = new BoardMatrix(); //array of 9 position XOX
                Reader board1Input = new Reader(); 
            for (program.i=0; program.i<9; program.i++)
            {
                board1Input.InputReader(board1, program);
            }

            Console.ReadKey();
        }
    }
}
