using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Printer
    {
        public void BoardPrinter (BoardMatrix board)
        {
            Console.WriteLine($"  {board.GetScore(6)} | {board.GetScore(7)} | {board.GetScore(8)}  ");
            Console.WriteLine($" ---+---+---  ");
            Console.WriteLine($"  {board.GetScore(3)} | {board.GetScore(4)} | {board.GetScore(5)}  ");
            Console.WriteLine($" ---+---+---  ");
            Console.WriteLine($"  {board.GetScore(0)} | {board.GetScore(1)} | {board.GetScore(2)}  ");
        }
    }
}
