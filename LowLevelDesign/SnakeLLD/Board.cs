using System;

namespace LowLevelDesign.SnakeLLD
{
    public class Board
    {
        public Board(int boardSize, int numberOfSnakes, int numberOfLadders)
        {
            InitializeCell(boardSize);
            AddSnakeAndLadder(Cells, numberOfLadders, numberOfSnakes);
        }

        public Cell[,] Cells { get; set; }


        private void InitializeCell(int boardSize)
        {
            Cells = new Cell[boardSize, boardSize];

            for(int i=0; i< boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                    Cells[i, j] = new Cell();
            }
        }

        private void AddSnakeAndLadder(Cell[,] cells, int numberOfLadders, int numberOfSnakes)
        {
            Random random = new Random();
            int length = cells.Length;

            while(numberOfLadders > 0)
            {
                int start = random.Next(1, length - 1);
                int end = random.Next(1, length - 1);

                if (start >= end)
                    continue;

                Jump jumpObj = new Jump(start, end);
                Cell cell = GetCell(start);

                cell.Jump = jumpObj;
                numberOfLadders--;
            }

            while (numberOfSnakes > 0)
            {
                int start = random.Next(1, length - 1);
                int end = random.Next(1, length - 1);

                if (start <= end)
                    continue;

                Jump jumpObj = new Jump(start, end);
                Cell cell = GetCell(start);

                cell.Jump = jumpObj;
                numberOfSnakes--;
            }
        }

        private Cell GetCell(int cellLocation)
        {
            int row = cellLocation / Cells.GetLength(0);
            int col = cellLocation % Cells.GetLength(0);

            return Cells[row, col];
        }
    }
}
