using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Winner
    {
        private int counter=0;
        private int[] win1 = new int[3] { 1, 2, 3 };
        private int[] win2 = new int[3] { 1, 5, 9 };
        private int[] win3 = new int[3] {1,4,7 };
        private int[] win4 = new int[3] {2,5,8 }; 
        private int[] win5 = new int[3] {3,6,9 }; 
        private int[] win6 = new int[3] {4,5,6 }; 
        private int[] win7 = new int[3] {3,5,7 }; 
        private int[] win8 = new int[3] {7,8,9 };

    public bool winChecker(Player playern)
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (win1[i] == playern.GetValue(j))
                    {
                        counter++;    
                        if (counter == 3) 
                        {
                            return true; 
                        }
                    }
                }
            }
            counter = 0;
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (  win2[i] == playern.GetValue(j))
                    {
                        counter++;    if (counter == 3) return true;
                    }
                }
            }
            counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (win3[i] == playern.GetValue(j))
                    {
                        counter++;    if (counter == 3) return true;
                    }
                }
            }
            counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (win4[i] == playern.GetValue(j))
                    {
                        counter++;    if (counter == 3) return true;
                    }
                }
            }
            counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (win5[i] == playern.GetValue(j))
                    {
                        counter++;    if (counter == 3) return true;
                    }
                }
            }
            counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (win6[i] == playern.GetValue(j))
                    {
                        counter++;    if (counter == 3) return true;
                    }
                }
            }
            counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (win7[i] == playern.GetValue(j))
                    {
                        counter++;    if (counter == 3) return true;
                    }
                }
            }
            counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (win8[i] == playern.GetValue(j))
                    {
                        counter++;    if (counter == 3) return true;
                    }
                }
            }
            counter = 0;
            return false;
        }
    }
}
