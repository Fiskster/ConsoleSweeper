using System;

namespace ConsoleSweeper
{
    public class SweeperGrid
    {
        public int y;
        public int x;

        public int[,] board = new int[20, 10];



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

                     
                }
            }

        
        }

    }
}
