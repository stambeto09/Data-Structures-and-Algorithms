namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    class StepInLabyrinth
    {
        static void Main()
        {
            SetInput();

            string[,] inputField = GetFieldFromConsole();
            Labyrinth labyrinth = new Labyrinth(inputField);
            labyrinth.FindSteps();
            // PrintField(inputField);

            Console.WriteLine(labyrinth.ToString());
        }

        private static void PrintField(string[,] inputField)
        {
            for (int row = 0; row < inputField.GetLength(0); row++)
            {
                for (int col = 0; col < inputField.GetLength(1); col++)
                {
                    Console.Write(inputField[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static string[,] GetFieldFromConsole()
        {
            string[,] field = null;
            int rowOnField = 0;

            while (true)
            {
                string inputRow = Console.ReadLine();
                if (string.IsNullOrEmpty(inputRow))
                {
                    break;
                }

                string[] cells = inputRow.Split();

                if (field == null)
                {
                    field = new string[cells.Length, cells.Length];
                }

                for (int index = 0; index < cells.Length; index++)
                {
                    field[rowOnField, index] = cells[index];
                }

                rowOnField++;

            }

            return field;
        }

        private static void SetInput()
        {
            StreamReader sr = new StreamReader("..\\..\\input.txt");

            using (sr)
            {
                var reader = new StringReader(sr.ReadToEnd());
                Console.SetIn(reader);
            }
        }
    }
}
