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
            Console.WriteLine($"  {board.GetPosition(6)} | {board.GetPosition(7)} | {board.GetPosition(8)}  ");
            Console.WriteLine($" ---+---+---  ");
            Console.WriteLine($"  {board.GetPosition(3)} | {board.GetPosition(4)} | {board.GetPosition(5)}  ");
            Console.WriteLine($" ---+---+---  ");
            Console.WriteLine($"  {board.GetPosition(0)} | {board.GetPosition(1)} | {board.GetPosition(2)}  ");
        }
    }
}
