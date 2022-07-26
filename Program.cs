using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum Options { X, O, Udf }

    class Program
    {
        static void Main()
        {
            BoardMatrix board1 = new BoardMatrix();
            Printer board1printer = new Printer();
            board1printer.PrintTheBoard(board1);
            Console.ReadKey();
        }
    }
}
