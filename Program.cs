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
                    Player player1=new Player();    //array of five places
                    Player player2=new Player();   //array of five places
            for (program.i=0; program.i<9; program.i++)
            {
                board1Input.InputReader(board1, player1, program);
            }

            Console.ReadKey();
        }
    }
}
