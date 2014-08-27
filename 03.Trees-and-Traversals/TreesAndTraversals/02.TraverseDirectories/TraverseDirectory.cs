namespace TraverseDirectories
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class TraverseDirectories
    {
        public static void Main()
        {
            const string ROOT_DIRECTORY = "C:\\Windows";

            List<string> directories = new List<string>();
            List<string> executables = new List<string>();
            StringBuilder errorLog = new StringBuilder();
            Queue<string> rootDirectories = new Queue<string>();

            rootDirectories.Enqueue(ROOT_DIRECTORY);
            while (rootDirectories.Count > 0)
            {
                var currentDirectory = rootDirectories.Peek();
                try
                {
                    foreach (var dir in Directory.GetDirectories(currentDirectory))
                    {
                        rootDirectories.Enqueue(dir);
                        directories.Add(dir);
                    }

                    var files = Directory.GetFiles(currentDirectory, "*.exe");
                    executables.AddRange(files);
                }
                catch (UnauthorizedAccessException ex)
                {
                    errorLog.AppendLine(ex.Message);
                }

                rootDirectories.Dequeue();
            }

            if (errorLog.Length > 0)
            {
                Console.WriteLine("Errors:");
                Console.WriteLine(errorLog);
            }

            Console.WriteLine("Directories:");
            PrintCollection(directories);

            Console.WriteLine("Executables:");
            PrintCollection(executables);
        }

        private static void PrintCollection(IEnumerable<string> elements)
        {
            StringBuilder elementsAsString = new StringBuilder();
            foreach (var element in elements)
            {
                elementsAsString.AppendLine(element);
            }

            Console.WriteLine(elementsAsString.ToString());
        }
    }
}