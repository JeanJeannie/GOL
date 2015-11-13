using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GOL;

namespace GOL
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxTicks = 5;
            var maxRow = 15;
            var maxCol = 25;

            //Console.SetCursorPosition(0, 0);
            //Console.Write(new string('#', maxCol));
            //for (int row = 1; row < maxRow; row++)
            //{
            //    Console.SetCursorPosition(0, row);
            //    Console.Write($"#{new string(' ', maxCol-2)}#");
            //}
            //Console.SetCursorPosition(0, maxRow);
            //Console.Write(new string('#', maxCol));

            //int data = 1;
            //System.Diagnostics.Stopwatch clock = new System.Diagnostics.Stopwatch();
            //clock.Start();
            //while (data < maxTicks)
            //{
            //    data++;
            //    Console.SetCursorPosition(1, 2);
            //    Console.Write("Current Value: " + data.ToString());
            //    Console.SetCursorPosition(1, 3);
            //    Console.Write("Running Time: " + clock.Elapsed.TotalSeconds.ToString());
            //    Thread.Sleep(1000);
            //}

            //Console.SetCursorPosition(0, maxRow + 2);
            var grid = new MyGrid(maxRow, maxCol, maxTicks);
            grid.ClearGrid();
            Console.Write("press any key to continue: ");
            Console.ReadKey();

            grid.RefreshGrid();


            Console.Write("press any key to exit: ");
            Console.ReadKey();
        }

    }
}
