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

            string[] lines = File.ReadAllLines(fullPath);

            List<string> result = [];
            foreach (string line in lines)
            {
                string convertedLine = ConvertToLowerCase(line);
                result.Add(convertedLine);
            }

            return result;
        }

        private static string ConvertToLowerCase(string line)
        {
            char[] chars = line.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]) && char.IsUpper(chars[i]))
                {
                    chars[i] = char.ToLower(chars[i]);
                }
            }
            return new string(chars);
        }
    }
}
