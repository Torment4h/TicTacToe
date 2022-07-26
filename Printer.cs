using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Printer
    {
        public void PrintTheBoard(BoardMatrix board)
        {
            for (int i=0;i<9;i++)
            {
                Console.WriteLine($"{board.GetValue(7)} | {board.GetValue(8)} | {board.GetValue(9)}");
                Console.WriteLine("---+---+---");
                Console.WriteLine($"{board.GetValue(4)} | {board.GetValue(5)} | {board.GetValue(6)}");
                Console.WriteLine("---+---+---");
                Console.WriteLine($"{board.GetValue(1)} | {board.GetValue(2)} | {board.GetValue(3)}");
                //if (i == 2 || i == 5) Console.WriteLine();
            }
        }
    }
}
