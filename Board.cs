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

        //Set value in the indicated position player and 

        //Returns the value of the given position
        public options GetPosition(int i){
            return this.board[i];
        }

        //Sets the sent value in the indicated position
        public void SetPosition(int i,options value){
            this.board[i-1] =value;
        }
    }
}
