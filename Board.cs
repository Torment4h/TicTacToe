using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class BoardMatrix
    {
        private Options[] board = new Options[9];


        //Constructor sets everything to undefined (the property)
        public BoardMatrix()
        {
            for (int i = 0; i < 3; i++) {
                    board[i] = Options.Udf;
                }
           }

        public Options GetValue(int i)
        {
            return this.board[i];
        }

        public void SetValue( int i, Options value)
        {
            this.board[i]=value;
        }
    }
}
