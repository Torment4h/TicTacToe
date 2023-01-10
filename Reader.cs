using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Reader
    {
        Player player1 = new Player();    //array of five places
        Player player2 = new Player();   //array of five places

        public int RangeOfNumber(UInt16 position, Program program)
        {
            if (position <= 0 || position >= 10)
            {
                Console.WriteLine("Invalid position :<");
                Console.ReadKey();
                program.i--;
                return 0;   
            }
            return 1;
        }


        public int NumberChecker (UInt16 position, Player player1, Player player2, Program program)
        {
            for(int i = 0; i < 5 ; i++)
            {
                if (position == player1.GetValue(i) || position == player2.GetValue(i))    
                {                                                                           
                    Console.WriteLine("Position already in use :<");
                    Console.ReadKey();
                    program.i--;
                    return 0;
                }
            }
            return 1;
        }

        public int InputReader(BoardMatrix board1, Program program, Printer board1Printer)
        {
            Winner winner = new Winner();

            if (program.i > 3 && winner.winChecker(player1))
            {
                Console.Clear();
                board1Printer.BoardPrinter(board1);
                Console.WriteLine("The player 1 won :>");
                program.i = 9;
                return 0;
            }
            else if (program.i > 3 && winner.winChecker(player2))
            {
                Console.Clear();
                board1Printer.BoardPrinter(board1);
                Console.WriteLine("The player 2 won :>");
                program.i = 9;
                return 0;
            }


            Console.Clear();          
                        
            UInt16 position = 0;                    //Read the keyboard input
            board1Printer.BoardPrinter(board1);     //Read the keyboard input
            Console.WriteLine("");                  //Read the keyboard input
            string temp = Console.ReadLine();       //Read the keyboard input
            position =Convert.ToUInt16(temp);       //Read the keyboard input

            if (RangeOfNumber(position, program) == 0 || NumberChecker(position, player1, player2, program) == 0) return 0;

                if (program.i % 2 == 0) //even number X player 1
                {
                player1.SetValue(position);
                    board1.SetPosition(position, options.X);
                    return 0;
                }

                else if (program.i % 2 == 1) // odd numbers O player 2
                {
                    player2.SetValue(position);
                    board1.SetPosition(position, options.O);
                    return 0;
                }
            
            return 0;
        }
    }
}
