using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    enum options {X, O, U }
    class BoardMatrix
    {
        //each player can choose a maximum of 5 times 
        private options[] board = new options[9];

        //Constructor initialize everything to undefined
        public BoardMatrix(){
                for(int i = 0; i <9; i++) board[i] = options.U;
        }

        //Returns the value of the given position
        public options GetScore(int i){
            return this.board[i];
        }

        //Sets the sent value in the indicated position
        public void SetScore(int i,options value){
            this.board[i] =value;
        }
    }
}
