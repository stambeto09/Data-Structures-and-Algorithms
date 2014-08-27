namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Labyrinth
    {
        string[,] field;
        static int[,] directions = 
        {
            {0, 1},
            {1, 0},
            {0, -1},
            {-1, 0},
        };

        int height = 0;
        int width = 0;
        Cell startCell;

        public Labyrinth()
        {

        }

        public Labyrinth(string[,] inputField) : this()
        {
            this.field = inputField;
            this.height = field.GetLength(1);
            this.width = field.GetLength(0);
            startCell = FindCell();
        }

        private Cell FindCell()
        {
            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < height; col++)
                {
                    if (field[row, col] == "*")
                    {
                        return new Cell(row, col, 0);
                    }
                }
            }

            throw new InvalidOperationException("The starting cell was not found.");
        }


        internal void FindSteps()
        {
            Queue<Cell> queue = new Queue<Cell>();
            queue.Enqueue(startCell);

            while (queue.Count > 0)
            {
                Cell currentCell = queue.Dequeue();

                for (int index = 0; index < directions.GetLength(0); index++)
                {
                    int nextRow = currentCell.Row + directions[index, 0];
                    int nextCol = currentCell.Col + directions[index, 1];

                    if (StepPossible(nextRow, nextCol))
                    {
                        Cell nextStep = new Cell(nextRow, nextCol, currentCell.Value + 1);
                        field[nextStep.Row, nextStep.Col] = nextStep.Value.ToString();
                        queue.Enqueue(nextStep);
                    }
                }
            }

            MarkUnpassable();
        }

        private void MarkUnpassable()
        {
            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < height; col++)
                {
                    if (field[row, col] == "0")
                    {
                        field[row, col] = "u";
                    }
                }
            }
        }

        private bool StepPossible(int nextRow, int nextCol)
        {
            bool isPossible = false;

            bool isRowInRange = nextRow >= 0 && nextRow < height;
            bool isColInRange = nextCol >= 0 && nextCol < width;
            if (isRowInRange && isColInRange && field[nextRow, nextCol] == "0")
            {
                isPossible = true;
            }

            return isPossible;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < height; col++)
                {
                    sb.AppendFormat("{0, -3}", field[row, col]);
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
