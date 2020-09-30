using System;

namespace ConsoleSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            SweeperGrid sweepergrid = new SweeperGrid();
            bool result = sweepergrid.CheckPosition(7, 10);
            System.Console.WriteLine(result);
            Console.ReadLine();
            Console.Clear();
            sweepergrid.Draw();
            Console.ReadLine();

        }
    }
}
