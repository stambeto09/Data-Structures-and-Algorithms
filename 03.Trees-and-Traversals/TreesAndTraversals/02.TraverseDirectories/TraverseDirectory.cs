namespace TreesAndTraversals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    class TraverseDirectory
    {
        static void Main()
        {
            string directoryPath = "C:\\";
            List<string> listOfFiles = SearchDirectory(directoryPath);

            foreach (var file in listOfFiles)
            {
                Console.WriteLine(file);
            }
        }

        private static List<string> SearchDirectory(string directoryPath)
        {
            List<string> listOfFiles = new List<string>();
            try
            {
                foreach (string directory in Directory.GetDirectories(directoryPath))
                {
                    foreach (string file in Directory.GetFiles(directory, ".exe"))
                    {
                        listOfFiles.Add(file);
                    }
                    SearchDirectory(directory);
                }
            }
            catch (SystemException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return listOfFiles;
        }
    }
}
