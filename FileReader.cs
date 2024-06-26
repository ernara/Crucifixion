using System;
using System.Collections.Generic;
using System.IO;

namespace Crucifixion
{
    internal class FileReader
    {
        public static List<string> ReadFile()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string relativePath = @"..\..\..\upes.csv";
            string fullPath = Path.GetFullPath(Path.Combine(currentDirectory, relativePath));

            List<string> lines = new List<string>(File.ReadAllLines(fullPath));

            List<string> filteredLines = new List<string>();

            foreach (string line in lines)
            {
                int length = line.Length;
                if (length < 4 || length == 5 || length == 8 || length > 9)
                {
                    
                }
                else
                {
                    filteredLines.Add(line);
                }
            }

            return filteredLines;
        }
    }
}
