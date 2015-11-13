using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GOL
{
    public class MyGrid
    {
        private int gridRows;
        private int gridCols;
        private int tickCount;

        private char[,] displayGrid;

        public MyGrid(int maxRows, int maxCols, int maxTicks)
        {
            gridRows = maxRows;
            gridCols = maxCols;
            tickCount = maxTicks;

            InitialiseDataGrid();
        }

        private void InitialiseDataGrid()
        {
            displayGrid = new char[gridRows, gridCols];

            for (int i = 0; i < gridCols; i++)
            {
                displayGrid[0, i] = 'x';  // fill first line with x's
            }
        }

        private void PositionCursorForInput()
        {
            Console.SetCursorPosition(0, gridRows + 4);
            Console.Write($"{new string(' ', gridCols + 10)}\r");
        }

        public void ClearGrid()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(new string('-', gridCols+2));
            for (int row = 1; row < gridRows+2; row++)
            {
                Console.SetCursorPosition(0, row);
                Console.Write($"|{new string(' ', gridCols)}|");
            }
            Console.SetCursorPosition(0, gridRows+2);
            Console.Write(new string('-', gridCols+2));

            PositionCursorForInput();
        }

        public void RefreshGrid()
        {
            int currTick = 1;
            System.Diagnostics.Stopwatch clock = new System.Diagnostics.Stopwatch();
            clock.Start();
            while (currTick < tickCount)
            {
                currTick++;
                RedrawData();
                //Console.SetCursorPosition(1, 2);
                //Console.Write("Current Value: " + data.ToString());
                //Console.SetCursorPosition(1, 3);
                //Console.Write("Running Time: " + clock.Elapsed.TotalSeconds.ToString());
                PositionCursorForInput();
                Console.Write($"tick count:{currTick}");
                Thread.Sleep(1000);
            }

            PositionCursorForInput();
        }

        public void RedrawData()
        {
            for (int curRow = 0; curRow < gridRows; curRow++)  // need to offset by 1
            {
                Console.SetCursorPosition(1, curRow+1); // start pos;
                for (int curCol = 0; curCol < gridCols; curCol++) // need to offset by 1
                {
                    Console.Write(displayGrid[curRow, curCol]);
                }
            }
        }

        public void UpdateData()
        {
            for (int curRow = 0; curRow < gridRows; curRow++)  // need to offset by 1
            {
                //Console.SetCursorPosition(1, curRow + 1); // start pos;
                for (int curCol = 0; curCol < gridCols; curCol++) // need to offset by 1
                {

                    //  Console.Write(displayGrid[curRow, curCol]);
                    CountNeighbours();
                }
            }
        }

        private void CountNeighbours(int row, int col)
        {
                
        }

        private class DataCell
        {
            public int Row { get; set; }
            public int Col { get; set; }
            public bool Live { get; set; }
            public int TotalNeighbours { get; set; }
        }

        private class Neighbours {
            public int LiveNeighbours { get; set; }
            public int DeadNeighbours { get; set; }

            public static Neighbours CountNeighbours(int row, int col)
            {
                return new Neighbours();
            }
        }

    }
}
