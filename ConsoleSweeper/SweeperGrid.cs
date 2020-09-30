using System;

namespace ConsoleSweeper
{
    public class SweeperGrid
    {
        public int y;
        public int x;

        public int[,] board = new int[40, 40];



        public SweeperGrid()
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    board[x, y] = 9;

                    if (x == 0)
                    {
                        board[x, y] = 2;
                    }
                    Random generator = new Random();
                    for (int i = 0; i < board.GetLength(0); i++)
                    {
                        board[generator.Next(0, board.GetLength(0)), generator.Next(0, board.GetLength(1))] = 10;
                    }


                }
            }


        }
        public bool CheckPosition(int x, int y)
        {
            if (x < 0 && x < 20 && y < 0 && y < 10)
            {
                return board[x, y] == 10;
            }
            else
            {
                return false;
            }


        }
        public void Draw()
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    if(board [x,y] == 10)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("█");
                    }
                
                }   
               
            
            
            } 
 

        }
    }
}
